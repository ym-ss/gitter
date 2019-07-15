using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace CLASES.Reportes
{
   public class creporteroles
    {
        public float[] GetColumnsZise(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {

                values[i] = float.Parse(dg.Columns[i].Width.ToString());
            }
            return values;
        }

        public void GenerarReporte(DataGridView dgv, string cmbestado, string cabeceratitulo, string usuarioactivo, string buscar, string parametro, string estado)
        {
            iTextSharp.text.Image img = Image.GetInstance(Application.StartupPath + @"\images\logo2.png");

            Document doc = new Document(PageSize.LETTER, 30, 20, 40, 60);
            //'indicamos donde vamos a guardar el documento
            string filename = @"C:\ReporteClientes.pdf";
            var writer = PdfWriter.GetInstance(doc,
                                                new FileStream(filename, FileMode.Create));
            writer.PageEvent = new creporteevento(usuarioactivo, buscar, parametro, estado);

            // 'abrimos el archivo
            doc.Open();
            img.SetAbsolutePosition(40, 711);
            img.ScalePercent(40);
            doc.Add(img);

            PdfContentByte rectangulo; // 'declaración del rectángulo
            rectangulo = writer.DirectContent;  // 'código necesario antes de dar coordenadas del rectángulo

            rectangulo.SetLineWidth(1); //'configurando el ancho de linea
            rectangulo.SetColorStroke(BaseColor.BLACK); //'dar color a trazo. Sin esto el rectángulo se dibuja con el ultimo color de trazo configurado
            rectangulo.Rectangle(33.0F, 763.0F, 555.0F, -84.0F); // '100.0F, 580.0F, coordenada punto de inicio
            rectangulo.Stroke();

            iTextSharp.text.Font _FontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font _cabeceraTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            iTextSharp.text.Font _FontCabecera = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _FontDetalle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _FontLogotipo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            PdfPTable datatable = new PdfPTable(dgv.ColumnCount);
            //'se asignan algunas propiedades para que el diseño del pdf
            datatable.DefaultCell.Padding = 3;
            float[] headerwith = new float[dgv.ColumnCount + 1];
            headerwith = GetColumnsZise(dgv);
            datatable.SetWidths(headerwith);

            datatable.WidthPercentage = 98;
            datatable.DefaultCell.BorderWidth = 3;

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            datatable.DefaultCell.Border = Rectangle.NO_BORDER;
            //'Se crea el encabezado del pdf
            Paragraph encabezado = new Paragraph(cabeceratitulo, _FontTitulo);
            encabezado.Alignment = Element.ALIGN_CENTER;
            // 'se crea el texto abajo del encabezado
            Paragraph telefono_ = new Paragraph("     TEL. 700-000001 - 3123456", _FontLogotipo);
            telefono_.Alignment = Element.ALIGN_LEFT;

            Paragraph direccion_ = new Paragraph("     Zona Equipetrol Av San Martin #77", _FontLogotipo);
            direccion_.Alignment = Element.ALIGN_LEFT;

            Paragraph correo_ = new Paragraph("     ventaterrenos@terrenos.com" + "   ", _FontLogotipo);
            correo_.Alignment = Element.ALIGN_LEFT;

            Paragraph espacio_ = new Paragraph("" + "   ", _FontLogotipo);
            espacio_.Alignment = Element.ALIGN_LEFT;

            Paragraph totalregistro = new Paragraph("          TOTAL DE REGISTROS: <<  " + dgv.RowCount + "  >> ", _FontCabecera);
            totalregistro.Alignment = Element.ALIGN_LEFT;

            Paragraph linea = new Paragraph("————————————————————————————————————————————");
            //'linea.Add(New Chunk(DGV.RowCount.ToString, _FontCabecera));

            linea.Alignment = Element.ALIGN_CENTER;

            // 'Se capturan los nombres del encabezado del datagridview
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                string cadena = dgv.Columns[i].HeaderText.ToString();
                iTextSharp.text.pdf.PdfPCell celda = new iTextSharp.text.pdf.PdfPCell(new Phrase(dgv.Columns[i].HeaderText, _cabeceraTitulo));
                celda.Colspan = 1;
                celda.Padding = 5;
                celda.BackgroundColor = iTextSharp.text.pdf.ExtendedColor.LIGHT_GRAY;
                celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                celda.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP;
                celda.FixedHeight = 20.0F;
                //'celda.Width = 100
                celda.Border = 0;
                datatable.AddCell(celda);
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    iTextSharp.text.pdf.PdfPCell celda = new iTextSharp.text.pdf.PdfPCell(new Phrase(dgv[j, i].Value.ToString(), _FontDetalle));
                    celda.Colspan = 1;
                    celda.Padding = 5;
                    celda.BackgroundColor = iTextSharp.text.pdf.ExtendedColor.WHITE;
                    celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    celda.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP;
                    celda.Border = 0;
                    datatable.AddCell(celda);
                }
                datatable.CompleteRow();
            }

            //'se agrega el datatable al pdf
            //'doc.SetMargins(40, 40, 40, 100)
            doc.Add(espacio_);
            doc.Add(espacio_);

            doc.Add(encabezado);

            //'doc.Add(Chunk.NEWLINE)
            doc.Add(telefono_);
            doc.Add(direccion_);
            doc.Add(correo_);
            doc.Add(espacio_);
            doc.Add(datatable);
            doc.Add(linea);
            doc.Add(totalregistro);

            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            doc.Close();
            writer.Close();
            Process.Start(filename);

        }


    }
}
