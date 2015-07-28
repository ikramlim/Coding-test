using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class populate_sortlist_statistic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

       // Random r = new Random();


        int rid = RandomNumber(-111, 999);
        int rid1 = RandomNumber(-111, 999);
        int rid2 = RandomNumber(-222, 888);
        int rid3 = RandomNumber(-333, 777);
        int rid4 = RandomNumber(-222, 777);
        int rid5 = RandomNumber(-333, 444);
        int rid6 = RandomNumber(-555, 888);
        int rid7 = RandomNumber(444, 999);
        int rid8 = RandomNumber(111, 222);
        int rid9 = RandomNumber(222, 333);

                txt1.Text = rid.ToString();
                txt2.Text = rid1.ToString();
                txt3.Text = rid3.ToString();
                txt4.Text = rid4.ToString();
                txt5.Text = rid5.ToString();
                txt6.Text = rid6.ToString();
                txt7.Text = rid7.ToString();
                txt8.Text = rid8.ToString();
                txt9.Text = rid9.ToString();
 
    }
    public int RandomNumber(int p1, int p2)
    {
        Random r = new Random();
        return r.Next(p1, p2);
    }



    
    protected void Button2_Click(object sender, EventArgs e)
    {

        int no1 = int.Parse(txt1.Text);
        int no2 = int.Parse(txt2.Text);
        int no3 = int.Parse(txt3.Text);
        int no4 = int.Parse(txt4.Text);
        int no5 = int.Parse(txt5.Text);
        int no6 = int.Parse(txt6.Text);
        int no7 = int.Parse(txt7.Text);
        int no8 = int.Parse(txt8.Text);
        int no9 = int.Parse(txt9.Text);

        int[] a = new int[] {no1,no2,no3,no4,no5,no6,no7,no8,no9 };
        int ctr = 0;

        Array.Sort(a);
        foreach (Control c in form1.Controls)
        {
            if (c is TextBox)
            {
                var textbox = c as TextBox;
                textbox.Text = a[ctr++].ToString();
            }
        }
        

    }



    protected void Button3_Click(object sender, EventArgs e)
    {
       
       
       // int sum = 0; //declare MEAN = 0 (average number)

        int no1 = int.Parse(txt1.Text);
        int no2 = int.Parse(txt2.Text);
        int no3 = int.Parse(txt3.Text);
        int no4 = int.Parse(txt4.Text);
        int no5 = int.Parse(txt5.Text);
        int no6 = int.Parse(txt6.Text);
        int no7 = int.Parse(txt7.Text);
        int no8 = int.Parse(txt8.Text);
        int no9 = int.Parse(txt9.Text);


        //group all the number in array....
        int[] a = new int[] { no1, no2, no3, no4, no5, no6, no7, no8, no9 };

        
        //display the MIN number
        int min = a[0]; //declare min = 0
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
                min = a[i];
        }
        lblMin.Text = min.ToString();
        
        
        //display the MAX number 
         int max = a[0]; //declare max = 0
         for ( int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
                max = a[i];
        }
        lblMax.Text = max.ToString();

        //display the MEAN number ( (a+b) /2)
         int sum = a[0]; //declare MEAN = 0 (average number)
         int sum1 = a[0];
       for (int j = 0; j < a.Length; j++)
        {
            sum =+ (a[j]) ;
            sum1 = sum / a.Length;
        }
        lblMean.Text = sum1.ToString();


        //display the range number max - min
        
        int total = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
                min = a[i];

            if (a[i] > max)
                max = a[i];

            total = max - min;

        }
        lblRange.Text = total.ToString();
        
       
    }
}