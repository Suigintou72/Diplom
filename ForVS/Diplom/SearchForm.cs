using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class SearchForm: Form
    {

        public SearchForm()
        {
            InitializeComponent();
        }

#pragma warning disable IDE1006 // Стили именования, чтобы не было ошибок
        private void btn_search_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования, чтобы не было ошибок
        ///Как происходит поиск по словам. Несколько слов подбираются в SelectionMode в Конструкторе.
        {
            listBox1.SelectedItems.Clear();
            for (int i=listBox1.Items.Count-1; i >= 0; i--)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(txt_search.Text.ToLower()))
                {
                    listBox1.SetSelected(i,true);
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            ///Нужно менять индексы, в зависимости от строки в ЛистБокс
            if (listBox1.SelectedIndex == 0)
            {
                Games.List2 lis = new Games.List2();
                lis.Show();
            }   
            
            if (listBox1.SelectedIndex == 1)
            {
                Games.List1 lis1 = new Games.List1();
                lis1.Show();
            }

            if (listBox1.SelectedIndex == 2)
            {
                Games.ListOther lis2 = new Games.ListOther();
                lis2.Show();
            }
        }
        ///Конец
    }
}
