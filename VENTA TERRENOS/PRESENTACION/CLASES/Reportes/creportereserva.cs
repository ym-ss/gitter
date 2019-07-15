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
using DATOS;
using System.Data;

namespace CLASES
{
    public class creportereserva
    {
        string _correo = "0";
        string _telefono = "0";
        
        public float[] GetColumnsZise(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            int cant2 = dg.ColumnCount - 1;
            for (int i = 0; i < cant2; i++)
            {

                values[i] = float.Parse(dg.Columns[i].Width.ToString());
            }
            return values;
        }

       
        public void GenerarReporte(DataGridView dgv, string cmbestado, string cabeceratitulo, string usuarioactivo, string buscar, string parametro, string estado, string datocliente)
        {
            //ObtenerRegistroEmpresa();

            iTextSharp.text.Image img = Image.GetInstance(Application.StartupPath + @"\images\logo2.png");

            Document doc = new Document(PageSize.LETTER, 30, 20, 40, 60);
            //'indicamos donde vamos a guardar el documento
            string filename = Application.StartupPath + @"\ReporteReserva.pdf";
            //MessageBox.Show(filename);
           // string filename = @"C:\prueba.pdf";
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

            PdfPTable tabladetalle = new PdfPTable(dgv.ColumnCount);
            PdfPTable tablacliente = new PdfPTable(2);
            tablacliente.WidthPercentage = 98;
            
          


            //'se asignan algunas propiedades para que el diseño del pdf
            tabladetalle.DefaultCell.Padding = 3;
            float[] headerwith = new float[dgv.ColumnCount + 1];
            headerwith = GetColumnsZise(dgv);
            tabladetalle.SetWidths(headerwith);

            tabladetalle.WidthPercentage = 98;
            tabladetalle.DefaultCell.BorderWidth = 3;

            tabladetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tabladetalle.DefaultCell.Border = Rectangle.NO_BORDER;
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

            Paragraph datoscliente = new Paragraph("           CLIENTE:  " + datocliente + "   ", _FontCabecera);
            totalregistro.Alignment = Element.ALIGN_LEFT;

            Paragraph linea = new Paragraph("————————————————————————————————————————————");
            //'linea.Add(New Chunk(DGV.RowCount.ToString, _FontCabecera));

            linea.Alignment = Element.ALIGN_CENTER;

            // 'Se capturan los nombres del encabezado del datagridview
            int cant1 = dgv.ColumnCount - 1;
            for (int i = 0; i < cant1; i++)
            {
                string cadena = dgv.Columns[i].HeaderText.ToString();
                iTextSharp.text.pdf.PdfPCell celda = new iTextSharp.text.pdf.PdfPCell(new Phrase(dgv.Columns[i].HeaderText, _cabeceraTitulo));
                celda.Colspan = 1;
                celda.Padding = 5;
                celda.BackgroundColor = iTextSharp.text.pdf.ExtendedColor.LIGHT_GRAY;
                celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                celda.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP;
                celda.FixedHeight = 20.0F;
                celda.Border = 0;
                tabladetalle.AddCell(celda);

            }
            tabladetalle.CompleteRow();
            //completamos con la captura de los encabezados


           //capturamos los datos del detalle
            for (int i = 0; i < dgv.RowCount; i++)
            {
                int cant = dgv.ColumnCount - 1;
                for (int j = 0; j < cant; j++)
                {
                    string cadena = dgv[j,i].Value.ToString();
                    iTextSharp.text.pdf.PdfPCell celda = new iTextSharp.text.pdf.PdfPCell(new Phrase(dgv[j, i].Value.ToString(), _FontDetalle));
                    celda.Colspan = 1;
                    celda.Padding = 5;
                    celda.BackgroundColor = iTextSharp.text.pdf.ExtendedColor.WHITE;
                    celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    celda.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP;
                    celda.Border = 0;
                    tabladetalle.AddCell(celda);
                }
                tabladetalle.CompleteRow();
            }
            //completamos con la captura del detalle

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
            doc.Add(espacio_);
            doc.Add(espacio_);
            //doc.Add(espacio_);
            //doc.Add(espacio_);

            doc.Add(datoscliente);

            doc.Add(tablacliente);
            doc.Add(espacio_);
            doc.Add(espacio_);
            //doc.Add(espacio_);
            //doc.Add(espacio_);

            doc.Add(tabladetalle);
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
