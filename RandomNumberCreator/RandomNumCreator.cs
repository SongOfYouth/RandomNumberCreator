using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomNumberCreator
{
    public partial class RandomNumCreator : Form
    {
        public RandomNumCreator()
        {
            InitializeComponent();
        }
        Hashtable htSplit = new Hashtable();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAverage.Text.Trim()) ||
                    string.IsNullOrEmpty(txtMax.Text.Trim()) ||
                    string.IsNullOrEmpty(txtMin.Text.Trim()) ||
                    string.IsNullOrEmpty(txtNum.Text.Trim()))
                {
                    MessageBox.Show("先完善必须的输入值！");
                    return;
                }
                int num = Convert.ToInt16(txtNum.Text.Trim());
                int average = Convert.ToInt16(txtAverage.Text.Trim());
                bool repeatable = this.chkRepeatable.Checked;
                int min = Convert.ToInt16(txtMin.Text.Trim());
                int max = Convert.ToInt16(txtMax.Text.Trim());
                if (min >= max)
                {
                    MessageBox.Show("最大值须大于最小值！");
                    return;
                }
                if (max<=0||min<0||num<=0||average<=0)
                {
                    MessageBox.Show("暂不支持负数或零的生成！");
                    return;
                }
                string split = htSplit[this.cmbSplit.SelectedIndex < 0 ? 0 : this.cmbSplit.SelectedIndex].ToString();
                int[] randoms = CreateRandom(min, max, average, num, repeatable);
                if (randoms == null || randoms.Length == 0)
                {
                    this.txtResult.Text = "生成失败！";
                    return;
                }
                this.txtResult.Text += string.Join(split, randoms)+ "\n";
                if (this.chkCheck.Checked)
                {
                    this.txtResult.Text += "总和：" + randoms.Sum() + ";均值：" + randoms.Sum() / randoms.Length + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RandomNumCreator_Load(object sender, EventArgs e)
        {
            htSplit[0] = ",";
            htSplit[1] = "\t";
            htSplit[2] = "\n";
            htSplit[3] = " ";
        }

        private int[] CreateRandom(int min,int max,int average,int num,bool repeatable = true)
        {
            int[] randoms = new int[num];
            for (int i = 0; i < num; i++)
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int n = random.Next(min, max);
                if (!repeatable)
                {
                    while (randoms.Contains(n))
                    {
                        n = random.Next(min, max);
                    }
                }
                randoms[i] = n;
            }
            if(randoms.Sum() != average*num) //如果平均值不为指定值则调整数组
            {
                AdjustArray(randoms, average * num,min,max,repeatable);
            }
            return randoms;
        }
        /// <summary>
        /// 数组调整：如果总和与预期不等，生成一个随机差值，并随机加到某一位上，直至符合预期
        /// </summary>
        /// <param name="repeatable">是否允许数组中含有重复值</param>
        private void AdjustArray(int[] array, int sum, int min,int max,bool repeatable)
        {

            Random random = new Random(Guid.NewGuid().GetHashCode());
            while (array.Sum() != sum)
            {
                int diff = sum - array.Sum();
                int adj = 0;
                adj = random.Next(0, max-min+1);
                int r = random.Next(0, array.Length - 1);
                if (diff > 0)
                {
                    if (array[r] + adj > max) continue;
                    if (!repeatable && adj != 0 && array.Contains(array[r] + adj)) continue;
                    array[r] += adj;
                }
                else
                {
                    if (array[r] - adj < min) continue;
                    if (!repeatable && adj != 0 && array.Contains(array[r] - adj)) continue;
                    array[r] -= adj;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = string.Empty;
        }
    }
}
