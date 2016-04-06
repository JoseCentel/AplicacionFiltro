using System;
using System.Diagnostics;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace Filtro.clases
{
    public class excel
    {
        private readonly Filtro filt = new Filtro();
        private db bd = new db();
        public void generarexcel(DateTimePicker dt)
        {
            var workbook = new XLWorkbook("clases/template.xlsx");
            var ws1 = workbook.Worksheet("Hoja2");
            var MyConString = "SERVER=//;" +
                              "DATABASE=//;" +
                              "UID=//;" +
                              "PASSWORD=//;";
            var connection = new MySqlConnection(MyConString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText =
                "SELECT registro_filtro.no_emp, registro_filtro.nombre_registrado,registro_filtro.celular," +
                "tel2,registro_filtro.bolsa," +
                "registro_filtro.lonche," +
                "registro_filtro.laptop," +
                "registro_filtro.lentes," +
                "registro_filtro.gorra," +
                "registro_filtro.otro," +
                "registro_filtro.comentario," +
                "registro_filtro.nombre_resp,hora_reg FROM " +
                "registro_filtro where " +
                "fecha_reg = '" + dt.Value.ToString("yyyy-MM-dd") + "'";
            Reader = command.ExecuteReader();
            var i = 3;
            ws1.Cell("A1").Value = dt.Value.ToString("ddd dd MMM yyyy");
            while (Reader.Read())
            {
              
                var a = "A" + i;
                var b = "B" + i;
                var c = "C" + i;
                var d = "D" + i;
                var e = "E" + i;
                var f = "F" + i;
                var g = "G" + i;
                var h = "H" + i;
                var ic = "I" + i;
                var j = "J" + i;
                var k = "K" + i;
                var l = "L" + i;
                var m = "M" + i;
                ws1.Cell(a).Value = Reader.GetString(0);
                ws1.Cell(b).Value = Reader.GetString(1);
                ws1.Cell(c).Value = Reader.GetString(2);
                ws1.Cell(d).Value = Reader.GetString(3);
                ws1.Cell(e).Value = Reader.GetString(4);
                ws1.Cell(f).Value = Reader.GetString(5);
                ws1.Cell(g).Value = Reader.GetString(6);
                ws1.Cell(h).Value = Reader.GetString(7);
                ws1.Cell(ic).Value = Reader.GetString(8);
                ws1.Cell(j).Value = Reader.GetString(9);
                ws1.Cell(k).Value = Reader.GetString(10);
                ws1.Cell(l).Value = Reader.GetString(11);
                ws1.Cell(m).Value = Reader.GetString(12);


                i++;
            }
            connection.Close();
            var date = filt.getNombre() + "_" + dt.Value.ToString("yyyy-MM-dd");
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
             workbook.SaveAs(dir + @"\reportes\"+date+".xlsx");
            System.Diagnostics.Process.Start(dir + @"\reportes\" + date + ".xlsx");
           
        }
}
}