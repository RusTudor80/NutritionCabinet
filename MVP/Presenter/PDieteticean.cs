using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MVP.Model;
using MVP.View;

namespace MVP.Presenter
{
    class PDieteticean
    {
        IDieteticean presenterDieteticean;
        ClientPersistenta clientul = new ClientPersistenta();
        public PDieteticean(IDieteticean view)
        {
            this.presenterDieteticean = view;
        }
        //task 1 afisarea listei de clienti
        public void ShowInfo()
        {
            List<Client> lista = clientul.loadClient();
            foreach (Client c in lista)
            {
                this.presenterDieteticean.tabel.Rows.Add(c.getNume(), c.getVarsta(), c.getGreutate(), c.getDieta());
            }
        }
        public void refreshInfo()
        {
            this.presenterDieteticean.tabel.Rows.Clear();
            this.presenterDieteticean.tabel.Refresh();
            this.ShowInfo();
        }
        public void cautareClient()
        {
            Client c = clientul.cautareClient(this.presenterDieteticean.search.Text);
            if(c.getNume()=="Nu")
            {
                string clientDate  = String.Format("Clientul {0} nu exista!", this.presenterDieteticean.search.Text);
                MessageBox.Show(clientDate, "Client :");
            }
            else
            {
                MessageBox.Show(c.ShowInfo1(), "Client");
            }
        }

        
        public void filtrareClient()
        {
            List<Client> lista = clientul.filtrareClient1(this.presenterDieteticean.selectie.Text, this.presenterDieteticean.filtru.Text);
            this.presenterDieteticean.tabel.Rows.Clear();
            this.presenterDieteticean.tabel.Refresh();
            foreach (Client cl in lista)
            {
                this.presenterDieteticean.tabel.Rows.Add(cl.getNume(), cl.getVarsta(), cl.getGreutate(), cl.getDieta());
            }
        }
        public void showStatistics()
        {
            List<Client> clienti = clientul.loadClient();
            if (this.presenterDieteticean.grafic.Text == "greutate")
            {
                int greutate1 = 0, greutate2 = 0,greutate3=0,greutate4=0,greutate5=0,greutate6=0;
                foreach (Client client1 in clienti)
                {
                    if (client1.getGreutate() > 40 && client1.getGreutate() < 50)
                        greutate1++;
                    if (client1.getGreutate() > 50 && client1.getGreutate() < 60)
                        greutate2++;
                    if (client1.getGreutate() > 60 && client1.getGreutate() < 70)
                        greutate3++;
                    if (client1.getGreutate() > 70 && client1.getGreutate() < 80)
                        greutate4++;
                    if (client1.getGreutate() > 80 && client1.getGreutate() < 90)
                        greutate5++;
                    if (client1.getGreutate() > 90 )
                        greutate6++;
                }
                Chart grafic1 = this.presenterDieteticean.statistica;
                grafic1.Series.Clear();
                grafic1.Legends.Clear();
                grafic1.Legends.Add("MyLegend");
                grafic1.Legends[0].LegendStyle = LegendStyle.Table;
                grafic1.Legends[0].Docking = Docking.Bottom;
                grafic1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
                grafic1.Legends[0].Title = "Greutatea clientilor";
                grafic1.Legends[0].BorderColor = System.Drawing.Color.Black;

                
                string seriesname = "MySeriesName";
                grafic1.Series.Add(seriesname);
            
                grafic1.Series[seriesname].ChartType = SeriesChartType.Pie;


                grafic1.Series[seriesname].Points.AddXY("Intre 40 si 50 de kg ", greutate1);
                grafic1.Series[seriesname].Points.AddXY("Intre 50 si 60 de kg ", greutate2);
                grafic1.Series[seriesname].Points.AddXY("Intre 60 si 70 de kg ", greutate3);
                grafic1.Series[seriesname].Points.AddXY("Intre 70 si 80 de kg ", greutate4);
                grafic1.Series[seriesname].Points.AddXY("Intre 80 si 90 de kg ", greutate5);
                grafic1.Series[seriesname].Points.AddXY("Peste 90 de kg ", greutate6);
                grafic1.Series[seriesname].IsValueShownAsLabel = true;

                grafic1.Visible = true;
            }

            if (this.presenterDieteticean.grafic.Text == "varsta")
            {
                int sub20 = 0;
                int intre20si30 = 0; 
                int intre30si40 = 0;
                int peste40 = 0;

                foreach (Client client1 in clienti)
                {
                    if (client1.getVarsta() <20)
                        sub20++;
                    if (client1.getVarsta() > 20 && client1.getVarsta()<30)
                        intre20si30++;
                    if (client1.getVarsta() < 40&&client1.getVarsta()>30)
                        intre30si40++;
                    if (client1.getVarsta() > 40)
                        peste40++;

                    Chart grafic2 = this.presenterDieteticean.statistica;
                    grafic2.Series.Clear();
                    grafic2.Legends.Clear();
                    grafic2.Legends.Add("MyLegend");
                    grafic2.Legends[0].LegendStyle = LegendStyle.Table;
                    grafic2.Legends[0].Docking = Docking.Bottom;
                    grafic2.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
                    grafic2.Legends[0].Title = "Varsta clientilor";
                    grafic2.Legends[0].BorderColor = System.Drawing.Color.Black;

                    string seriesname = "Varsta";
                    grafic2.Series.Add(seriesname);
                    //set the chart-type to "Pie"
                    grafic2.Series[seriesname].ChartType = SeriesChartType.Column;

                    grafic2.Series[seriesname].Points.AddXY("Clienti cu varsta sub 20 de ani", sub20);
                    grafic2.Series[seriesname].Points.AddXY("Clienti cu varsta intre 20 si 30 de ani", intre20si30);
                    grafic2.Series[seriesname].Points.AddXY("Clienti cu varsta intre 30 si 40 de ani", intre30si40);
                    grafic2.Series[seriesname].Points.AddXY("clienti cu varsta peste 40 de ani", peste40);
                    grafic2.Series[seriesname].IsValueShownAsLabel = true;
                    grafic2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    grafic2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                    grafic2.Visible = true;

                }
            }

        }



    }
}
