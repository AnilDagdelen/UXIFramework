using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WindowsFormsApp1;

namespace FacebookWeb
{
    public class UXMainClass
    {
        List<ChartData> Datas = new List<ChartData>();
        string[] Currencies = new string[] { "ETH", "XMR", "XBC", "XRP", "ETC" };

        public void UXInit(Page P)
        { 
            Run();//Datas list is filled
            GridView GV = new GridView() { CssClass = "StickyGrid", Width = 400, Height = 500 };
            GV.DataSource = Datas;

            GV.DataBind();
            ((GridViewRow)GV.Controls[0].Controls[0]).Cells.AddAt(0,new TableCell() { Text="Currency"});
            for (int i1 = 1; i1 < 6; i1++)
            { 
                ((GridViewRow)GV.Controls[0].Controls[i1]).Cells.AddAt(0, new TableCell() { Text = Currencies[i1-1] });
            }
            for (int i1 = 0; i1 < 6; i1++)
            {
                ((GridViewRow)GV.Controls[0].Controls[i1]).Cells.RemoveAt(1);
                ((GridViewRow)GV.Controls[0].Controls[i1]).Cells.RemoveAt(6);
            }
            for (int i1 = 1; i1 < 14; i1+=2)
            {
                var s=(HtmlGenericControl)P.Controls[3].Controls[i1]; 
                s.InnerHtml = s.InnerHtml.Insert(22, "y");
            } 
            P.Form.Controls.Add(GV);
            P.Form.Style.Add("background-color", "yellow");

        }

        private void Run()
        {

            Proceed(Currencies[0]);
            Proceed(Currencies[1]);
            Proceed(Currencies[2]);
            Proceed(Currencies[3]);
            Proceed(Currencies[4]);
        }

        private void Proceed(string Name)
        {
            try
            {

                string s1 = HttpHelper.Get("returnChartData&currencyPair=BTC_" + Name + "&start=" + Convert.ToInt64((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1) + new TimeSpan(0, 0, 10, 0))).TotalSeconds) + "&end=" + Convert.ToInt64((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) + "&period=300");
                List<ChartData> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChartData>>(s1);
                Datas.Add(Data[0]);
            }
            catch (Exception)
            {
            }
        }
    }
}
