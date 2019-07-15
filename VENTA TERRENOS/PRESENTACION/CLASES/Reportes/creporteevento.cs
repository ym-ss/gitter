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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CLASES
{
    public class creporteevento: PdfPageEventHelper
    {
        private string usuarioactivo_;
        private string buscar_;
        private string atributo_;
        private string estado_;

        public string Estado
        {
            get
            {
                return estado_;
            }
            set
            {
                estado_ = value;
            }
        }
        public string Atributo
        {
            get
            {
                return atributo_;
            }
            set
            {
                atributo_ = value;
            }
        }
        public string Buscar
        {
            get
            {
                return buscar_;
            }
            set
            {
                buscar_ = value;
            }
        }
        public string UsuarioActivo
        {
            get
            {
                return usuarioactivo_;
            }
            set
            {
                usuarioactivo_ = value;
            }
        }

        public  creporteevento(string UsuarioActivo, string buscar, string parametro, string estado)
        {
            usuarioactivo_ = UsuarioActivo;
            buscar_ = buscar;
            atributo_ = parametro;
            estado_ = estado;
        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);
        }

        private PdfContentByte cb;
        private PdfTemplate headerTemplate, footerTemplate;
        private BaseFont bf = null/* TODO Change to default(_) if this is not a reference type */;

        private string _header;
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
            }
        }
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            // MyBase.OnOpenDocument(writer, document)
            bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb = writer.DirectContent;
            headerTemplate = cb.CreateTemplate(100, 100);
            footerTemplate = cb.CreateTemplate(50, 50);
        }
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb = writer.DirectContent;


            headerTemplate = cb.CreateTemplate(100, 100);
            footerTemplate = cb.CreateTemplate(50, 50);

            var tabFot = new PdfPTable(4);
            // Dim cell As PdfPCell
            // tabFot.TotalWidth = 300.0F
            // '//cell = New PdfPCell(New Phrase("Footer"))
            // '//tabFot.AddCell(cell)
            // tabFot.WriteSelectedRows(0, -1, 150, document.Bottom, writer.DirectContent)
            var Text = "Pagina: " + writer.PageNumber + "  ";

            // cb.BeginText()
            // cb.SetFontAndSize(bf, 12)
            // cb.SetTextMatrix(document.PageSize.GetRight(200), document.PageSize.GetTop(45))
            // cb.ShowText(Text)
            // cb.EndText()
            // Dim len1 As Single = bf.GetWidthPoint(Text, 12)
            // '//Adds "12" in Page 1 of 12
            // cb.AddTemplate(headerTemplate, document.PageSize.GetRight(200) & len1, document.PageSize.GetTop(45))

            // //Add paging to footer
            // (
            float len = bf.GetWidthPoint(Text, 8);

            // cb.BeginText()
            // cb.SetFontAndSize(bf, 18)
            // cb.SetTextMatrix(document.PageSize.GetLeft(300), document.PageSize.GetBottom(700))
            // cb.ShowText("TITULO")
            // cb.EndText()
            // len = bf.GetWidthPoint("TITULO", 18)
            // cb.AddTemplate(footerTemplate, document.PageSize.GetLeft(300) & len, document.PageSize.GetBottom(700))


            string fechareporte = "FECHA EMISION: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            cb.BeginText();
            cb.SetFontAndSize(bf, 7);
            cb.SetTextMatrix(document.PageSize.GetLeft(50), document.PageSize.GetBottom(20));
            cb.ShowText(fechareporte);
            cb.EndText();
            len = bf.GetWidthPoint(fechareporte, 7);
            cb.AddTemplate(footerTemplate, document.PageSize.GetLeft(50) + len, document.PageSize.GetBottom(20));

            cb.BeginText();
            cb.SetFontAndSize(bf, 7);
            cb.SetTextMatrix(document.PageSize.GetLeft(300), document.PageSize.GetBottom(20));
            cb.ShowText(Text);
            cb.EndText();
            len = bf.GetWidthPoint(Text, 7);
            cb.AddTemplate(footerTemplate, document.PageSize.GetLeft(300) + len, document.PageSize.GetBottom(20));

            string usuario = "<< " + UsuarioActivo + " >>";
            cb.BeginText();
            cb.SetFontAndSize(bf, 7);
            cb.SetTextMatrix(document.PageSize.GetRight(150), document.PageSize.GetBottom(20));
            cb.ShowText(usuario);
            cb.EndText();
            len = bf.GetWidthPoint(usuario, 7);
            cb.AddTemplate(footerTemplate, document.PageSize.GetRight(150) + len, document.PageSize.GetBottom(20));

            //string linea = "————  ARGUMENTOS  ——————————————————————————————————————————————————————————————————";
            //cb.BeginText();
            //cb.SetFontAndSize(bf, 7);
            //cb.SetTextMatrix(document.PageSize.GetLeft(35), document.PageSize.GetBottom(60));
            //cb.ShowText(linea);
            //cb.EndText();
            //len = bf.GetWidthPoint(linea, 7);
            //cb.AddTemplate(footerTemplate, document.PageSize.GetLeft(35) + len, document.PageSize.GetBottom(60));

            

            //PdfContentByte rectangulo; // declaración del rectángulo
            //rectangulo = writer.DirectContent; // código necesario antes de dar coordenadas del rectángulo

            //rectangulo.SetLineWidth(1); // configurando el ancho de linea
            //rectangulo.SetColorStroke(BaseColor.BLACK); // dar color a trazo. Sin esto el rectángulo se dibuja con el ultimo color de trazo configurado
            //rectangulo.Rectangle(33.0F, 763.0F, 555.0F, -730.0F); // 100.0F, 580.0F, coordenada punto de inicio
            //rectangulo.Stroke(); // traza el rectangulo actual       '200.0F, ancho del rectángulo. '-100.0F alto del rectángulo

            // ----------------------------------------------------------------------------------------------------------------
            // ARGUMENTOS PIE DE PAGINA
            // ----------------------------------------------------------------------------------------------------------------
            //string busqueda = "BUSQUEDA: -" + buscar_ + "-";
            //cb.BeginText();
            //cb.SetFontAndSize(bf, 7);
            //cb.SetTextMatrix(document.PageSize.GetLeft(50), document.PageSize.GetBottom(45));
            //cb.ShowText(busqueda);
            //cb.EndText();

            //len = bf.GetWidthPoint(busqueda, 7);
            //cb.AddTemplate(footerTemplate, document.PageSize.GetLeft(50) + len, document.PageSize.GetBottom(45));

            //string atributo = "ATRIBUTO: " + atributo_ + "";
            //cb.BeginText();
            //cb.SetFontAndSize(bf, 7);
            //cb.SetTextMatrix(document.PageSize.GetLeft(280), document.PageSize.GetBottom(45));
            //cb.ShowText(atributo);
            //cb.EndText();

            //len = bf.GetWidthPoint(atributo, 7);
            //cb.AddTemplate(footerTemplate, document.PageSize.GetLeft(280) + len, document.PageSize.GetBottom(45));

            //string estado = "ESTADO: " + estado_ + "";
            //cb.BeginText();
            //cb.SetFontAndSize(bf, 7);
            //cb.SetTextMatrix(document.PageSize.GetRight(150), document.PageSize.GetBottom(45));
            //cb.ShowText(estado);
            //cb.EndText();
            //len = bf.GetWidthPoint(estado_, 7);
            //cb.AddTemplate(footerTemplate, document.PageSize.GetRight(150) + len, document.PageSize.GetBottom(45));
        }


        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
        }

    }
}
