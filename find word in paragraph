using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ash : System.Web.UI.Page
{
    int counter = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string tofind = TextBox1.Text;
        string para = Request.Form["TextArea1"];
       // int l = para.Length;
        //while (i < l)
        //{
            //if (para.Contains(tofind))
            //{
             //   counter++;
           // }
        //}
        string[] words = para.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
if(words[i].Contains(tofind))
{
    counter++;
}
        }
        Label1.Text =tofind+" occured "+ counter.ToString()+" times";
        Label2.Text ="total words are:"+ words.Length.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string tofind = TextBox1.Text;
        string para = Request.Form["TextArea1"];
        string[] words = para.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
for(int j=0;j<=(words[i].Length-tofind.Length);j++)
{
    if(tofind==((words[i]).Substring(j,tofind.Length)))
    {
        counter++;
    }
}
        }
        Label1.Text ="<h1>"+tofind+" occured "+ counter.ToString()+" times</h1>";
        Label2.Text ="total words are:"+ words.Length.ToString();
    }
    }
