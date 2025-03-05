using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Ketnoi xl = new Ketnoi();
        List<string> list = new List<string>();
        List<string> list2 = new List<string>();
        List<string> benh = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            list = xl.Trieuchung("select Distinct tentrieuchung from chuandoanbenh");
            foreach (string x in list)
            {
                lbdstrieuchung.Items.Add(x);
            }
            List<string> timbenh = xl.Benh("select Distinct tenbenh from chuandoanbenh");
            foreach (string result in timbenh) 
            {
                if (kiemtra(result, list)==false) {
                    benh.Add(result);
                }
            }
        }

        private void dstc(object sender, EventArgs e)
        {
            if (!lbdstrieuchung.SelectedItem.ToString().Equals(""))
            {
                btnThem.Enabled = true;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!lbdstrieuchung.SelectedItem.ToString().Equals(""))
            {
                
                    if (kiemtra(lbdstrieuchung.SelectedItem.ToString(),list2))
                    {
                        MessageBox.Show("Triệu chứng này đã có!");
                        return;
                    }
                
                lbtrieuchung.Items.Add(lbdstrieuchung.SelectedItem);
                list2.Add(lbdstrieuchung.SelectedItem.ToString());
                btnXoaall.Enabled = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!lbtrieuchung.SelectedItem.ToString().Equals(""))
            {

                list2.Remove(lbtrieuchung.SelectedItem.ToString());
                lbtrieuchung.Items.Remove(lbtrieuchung.SelectedItem);
            }
            btnXoa.Enabled = false;
            if (lbtrieuchung.Items.Count == 0)
            {
                btnXoaall.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbtrieuchung.Items.Clear();
            btnXoaall.Enabled = false;
            list2.Clear();
            
        }

        public Boolean kiemtra(string a, List<string> list)
        {
            foreach (string i in list)
            {
                if (a.Equals(i)) { return true; }
            }
            return false;
        }

        //Dictionary<string, List<String>> getDanhSachBenhVaTC()
        //{
        //    Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        //    string sql = @"SELECT * FROM CHUANDOANBENH ORDER BY TENBENH ASC";
        //    DataTable dataTbale = xl.ExcuteQuery(sql);
        //    List<int> listVitri = new List<int>();
        //    for (int i = 0; i <= dataTbale.Rows.Count - 2; i++)
        //    {
        //        if (dataTbale.Rows[i]["TENBENH"].ToString() != dataTbale.Rows[i + 1]["TENBENH"].ToString())
        //        {
        //            listVitri.Add(i);
        //        }
        //        if (i == dataTbale.Rows.Count - 2) listVitri.Add(i + 1);
        //    }

        //    List<List<int>> listTrave = new List<List<int>>();
        //    int count = listVitri.Count;
        //    for (int i = count - 1; i >= 0; i--)
        //    {
        //        if (i == 0)
        //        {
        //            List<int> item = new List<int>();
        //            item.Add(listVitri[i]);
        //            item.Add(0);
        //            listTrave.Add(item);
        //        }
        //        else
        //        {
        //            List<int> item = new List<int>();
        //            item.Add(listVitri[i]);
        //            item.Add(listVitri[i - 1] + 1);
        //            listTrave.Add(item);
        //        }
        //    }

        //    Console.WriteLine("Kết quả gần đúng");
        //    foreach (int i in listVitri)
        //    {
        //        Console.Write(i + "---");
        //    }

        //    Console.WriteLine("Kết quả đúng");
        //    Dictionary<string, List<String>> dictionary = new Dictionary<string, List<string>>();
        //    foreach (List<int> item in listTrave)
        //    {
        //        if (item[0] == item[1])
        //        {
        //            List<string> itemTrieuChung = new List<string>();
        //            itemTrieuChung.Add(dataTbale.Rows[item[0]]["TENTRIEUCHUNG"].ToString());
        //            dictionary.Add(dataTbale.Rows[item[0]]["TENBENH"].ToString(), itemTrieuChung);
        //        }
        //        else
        //        {
        //            List<string> itemTrieuChung = new List<string>();
        //            for (int i = item[1]; i <= item[0]; i++)
        //            {
        //                itemTrieuChung.Add(dataTbale.Rows[i]["TENTRIEUCHUNG"].ToString());
        //            }
        //            dictionary.Add(dataTbale.Rows[item[0]]["TENBENH"].ToString(), itemTrieuChung);
        //        }
        //    }
        //    return dictionary;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Ketqua();
        }

        private void Ketqua()
        {
            lbchuandoan.Items.Clear();
            
            List<string> listtam = list2;
            List<string> newlist = Chuandoan(listtam);
            List<string> newlist2 = Chuandoan(listtam);
            do
            {
                newlist = newlist2;
                newlist2 = Chuandoan(newlist);
            }
            while (newlist2.Count > newlist.Count);

            

            lbchuandoan.Items.Add(" ");
            lbchuandoan.Items.Add("Các bệnh có thể mắc phải: ");
            int dem = 0;
            foreach(string b in newlist)
            {
                if (kiemtra(b, benh) == true)
                {
                    lbchuandoan.Items.Add(b);
                    dem++;
                }
            }
            if (dem == 0)
            {
                lbchuandoan.Items.Add("Bạn không bị bệnh về phổi.");
            }
        }
            private List<string> Chuandoan(List<string> listx)
        {
            List<string> newlist = listx;
            int tm = 0;
            int slluat = 0;
            string vephai = "";
            DataTable dt = xl.ExcuteQuery("select * from chuandoanbenh order by tenbenh asc");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    vephai = dt.Rows[0]["tenbenh"].ToString();
                    for (int j = 0; j < newlist.Count; j++)
                    {
                        if (newlist[j].Equals(dt.Rows[0]["tentrieuchung"].ToString()))
                        {
                            tm++;
                        }

                    }

                }
                else if (i > 0)
                {
                    if (!dt.Rows[i]["tenbenh"].Equals(dt.Rows[i - 1]["tenbenh"]))
                    {
                        if (tm == slluat)
                        {
                            if (kiemtra(vephai, newlist) == false)
                            {
                                newlist.Add(vephai);
                            }
                            
                        }
                        vephai = dt.Rows[i]["tenbenh"].ToString();
                        tm = 0;
                        slluat = 0;
                    }
                    for (int j = 0; j < newlist.Count; j++)
                    {
                        if (newlist[j].Equals(dt.Rows[i]["tentrieuchung"].ToString()))
                        {
                            tm++;
                        }

                    }
                }
                if (i == dt.Rows.Count-1)
                {
                    slluat++;
                    if (tm == slluat)
                    {
                        if (kiemtra(vephai, newlist) == false)
                        {
                            newlist.Add(vephai);
                        }
                    }
                }
                slluat++;
            }
            return newlist;
        }

        private void lbdstrieuchung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clicktrieuchung(object sender, EventArgs e)
        {
            if (lbtrieuchung.SelectedItem != null)
            {
                btnXoa.Enabled = true;
                btnXoaall.Enabled = true;
            }
        }

        private void btnCstt_Click(object sender, EventArgs e)
        {
            lbcstt.Items.Clear();
            Coso(lbcstt);

        }

        private void Coso(ListBox x)
        {
            string luat = "";
            
            DataTable dt = xl.ExcuteQuery("select * from chuandoanbenh order by tenbenh asc");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    luat +=" & "+ dt.Rows[i]["tentrieuchung"].ToString();

                }
                else if (i > 0)
                {
                    if (!dt.Rows[i]["tenbenh"].Equals(dt.Rows[i - 1]["tenbenh"]))
                    {
                        luat +=" => "+ dt.Rows[i - 1]["tenbenh"];
                        x.Items.Add(luat);
                        luat = "";

                    }
                    luat +=" & "+ dt.Rows[i]["tentrieuchung"].ToString();
                }
                if (i == dt.Rows.Count - 1)
                {
                    luat +=" => "+ dt.Rows[i]["tenbenh"].ToString();
                    x.Items.Add(luat);
                    
                }
                
            }
        }
    }
    
}
