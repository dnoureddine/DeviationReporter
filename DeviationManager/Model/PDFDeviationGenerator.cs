using DeviationManager.Entity;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Model
{
    public class PDFDeviationGenerator
    {
        private Document doc;
        private Font normal;
        private Font normalBold;
        private Font small;
        private Font bigBold;
        private LanguageModel languageModel;

        public PDFDeviationGenerator(int x1, int x2, int x3, int x4)
        {
            doc = new Document(PageSize.A4, x1, x2, x3, x4);
            normal = FontFactory.GetFont("Arial", 7, BaseColor.BLACK);
            normalBold = FontFactory.GetFont("Arial", 7, Font.BOLD);
            small = FontFactory.GetFont("Arial", 6);
            bigBold = FontFactory.GetFont("Arial", 14, Font.BOLD);
            languageModel = new LanguageModel();
        }


        // get Pdf Writer to be able to write in the document 
        public PdfWriter getPdfWriter(String filePath)
        {
            PdfWriter pdfWriter = PdfWriter.GetInstance(this.doc, new System.IO.FileStream(filePath, System.IO.FileMode.Append));
            this.doc.Open();

            return pdfWriter;
        }


        //add table cell
        private void addTableCell(PdfPTable table, String text, Font font, int collapse, int allignement)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Colspan = collapse;
            cell.Padding = 4;
            cell.HorizontalAlignment = allignement;
            table.AddCell(cell);
        }

        //add table cell for page foot
        private void addTableCellForPageFoot(PdfPTable table, String text, Font font, int collapse, int allignement)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Colspan = collapse;
            cell.Padding = 4;
            cell.Border = 0;
            cell.HorizontalAlignment = allignement;
            table.AddCell(cell);
        }

        //add table Cell with image
        private  void addTableCell(PdfPTable table){
            Image crossImg = Image.GetInstance("cross.PNG");
            crossImg.ScaleAbsolute(6,6);

            PdfPCell cross = new PdfPCell(crossImg);
            cross.HorizontalAlignment = 1;
            cross.Padding = 4;
            table.AddCell(cross);

        }

        //add table cell
        private void addTableCell(PdfPTable table, String text, Font font, int collapse, int allignement, String color)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
#pragma warning disable CS0612 // Type or member is obsolete
            BaseColor cellBackColor = WebColors.GetRGBColor(color);
#pragma warning restore CS0612 // Type or member is obsolete
            cell.BackgroundColor = cellBackColor;
            cell.Colspan = collapse;
            cell.Padding = 4;
            cell.HorizontalAlignment = allignement;
            table.AddCell(cell);
        }


        // using the pdf writer generate the page header
        public PdfPTable generatePageHead()
        {
            PdfPTable table = new PdfPTable(7);
            table.WidthPercentage = 100;

            Image logoIm = Image.GetInstance("logo.PNG");
            PdfPCell logo = new PdfPCell(logoIm);
            logo.FixedHeight = 50f;
            logo.Colspan = 2;
            logo.Padding = 4;
            logo.HorizontalAlignment = 1;
            table.AddCell(logo);

            //Title  cell
            this.addTableCell(table, "Deviation-Report / Abweichungserlaubnis", bigBold, 5, 1);

            //Document Number  cell
            this.addTableCell(table, "Document Number: FTDS-BM-F-001", normal, 2, 0);

            //Process Chqmpion  cell
            this.addTableCell(table, "Process Champion:  Global Quality Standards Manager", normal, 5, 0);


            //Document title  cell
            this.addTableCell(table, "Document Title:  DEVIATION REPORT", normal, 2, 0);

            //Process Approver cell
            this.addTableCell(table, "Process Approver:  Global Quality & Warranty Director", normal, 5, 0);

            //user Document cell
            this.addTableCell(table, "Usage of Document:", normal, 1, 0);

            //FTDS -BM-P-008 Deviation Control Procedure cell
            this.addTableCell(table, "FTDS -BM-P-008 Deviation Control Procedure Documentation and Approval of Deviations which are departures from standard procedures, product specifications or process controls.", normal, 3, 0);


            //scope of document  cell
            this.addTableCell(table, "Scope of Document:", normal, 1, 0);

            //TI FTDS Division  cell
            this.addTableCell(table, "TI FTDS Division", normal, 2, 0);



            return table;

        }


        public PdfPTable createDeviationContent(PdfPTable table, Deviation deviation)
        {
            //Deviation No cell
            this.addTableCell(table, "ABWEICHUNG NR.:", normal, 1, 0, "#99ccff");

            //Deviation No Value cell
            this.addTableCell(table, "DR-"+deviation.deviationRef, normal, 2, 0);

            // Risk Category cell
            this.addTableCell(table, "RISIKOKATEGORIE / (circle relevant):", normal, 2, 0, "#99ccff");

            // Risk Category Value cell
            String riskCat = deviation.deviationRiskCategory;
            String color = "";
            if (riskCat == "GRÜN")
            {
                color = "green";
            }else if (riskCat == "ROT")
            {
                color = "red";
            }else if (riskCat == "GELB")
            {
                color = "yellow";
            }

            this.addTableCell(table,deviation.deviationRiskCategory, normal, 2, 0, color);

            // Requested by cell
            this.addTableCell(table, "ERSTELLT VON:", normal, 1, 0);

            // Requested by value cell
            this.addTableCell(table, deviation.requestedBy, normal, 3, 0);

            // DATE cell
            this.addTableCell(table, "DATE:", normal, 1, 0);

            // DATE value cell
            this.addTableCell(table, deviation.dateCreation.ToString(), normal, 2, 0);

            // Signature cell
            this.addTableCell(table, "UNTERSCHRIFT:", normal, 1, 0);

            //Signature value cell
            this.addTableCell(table, "", normal, 3, 0);

            // position cell
            this.addTableCell(table, "POSITION:", normal, 1, 0);

            // position value cell
            this.addTableCell(table, deviation.position, normal, 2, 0);

            // deviation type cell
            this.addTableCell(table, "ABWEICHUNG ART:", normal, 2, 0,"#99ccff");

            // deviation type value cell
            this.addTableCell(table, deviation.deviationType, normal, 1, 0,"#ff9900");

            // Other Description value cell
            this.addTableCell(table, "Other : "+deviation.describeOtherType, normal, 7, 0);

            // Detail description of deviation cell
            this.addTableCell(table, "DETAILED DESCRIPTION OF DEVIATION (detail product name / procedure number / specification / etc) \n Detaillierte Beschreibung der Abweichung ( Produkt Nr., Anweisungs Nr.:, Spezifikation, Verfahrensanweisungsnr., usw.)", normal, 7, 0);

            // Standard condition cell
            this.addTableCell(table, "Beschreibung Istzustand", normal, 3, 1, "#C4C7C3");

            // detail requested condition cell
            this.addTableCell(table, "Beschreibung Sollzustand", normal, 4, 1, "#C4C7C3");

            // Standard condition  value cell
            String productanlage = deviation.product;
            if (productanlage != "")
            {
                if (deviation.anlage != "")
                {
                    productanlage = productanlage + " / Anlage " + deviation.anlage;
                }
            }
            else
            {
                productanlage = deviation.anlage;
            }

            if (productanlage != "")
            {
                productanlage = productanlage + " ";
            }

            this.addTableCell(table, productanlage + deviation.detailRequestCondition, normal, 3, 0);

            // detail requested condition value  cell
            this.addTableCell(table, deviation.detailStandardCondition, normal, 4, 0);

            // 5 why cell
            this.addTableCell(table, "DETAIL 5 WHY TO SHOW REASON CHANGE FOR DEVIATION:", normal, 7, 0, "#C4C7C3");

            // why 1 cell
            var reasons = deviation.reasons;
            this.addTableCell(table, "WHY: " + reasons.ElementAt<Reason>(0).reason, normal, 7, 0);

            // why 2 cell
            this.addTableCell(table, "WHY: " + reasons.ElementAt<Reason>(1).reason, normal, 7, 0);

            // why 3 cell
            this.addTableCell(table, "WHY: " + reasons.ElementAt<Reason>(2).reason, normal, 7, 0);

            // why 4 cell
            this.addTableCell(table, "WHY: " + reasons.ElementAt<Reason>(3).reason, normal, 7, 0);

            // why 5 cell
            this.addTableCell(table, "WHY: " + reasons.ElementAt<Reason>(4).reason, normal, 7, 0);

            // Period deviation cell
            this.addTableCell(table, "Zeitraum für Abweichung(Schicht / Woche / usw.)", normal, 3, 0, "#C4C7C3");

            // Period deviation value  cell           

            this.addTableCell(table, "Von: "+deviation.startDatePeriod.ToString()+"  Bis: "+deviation.endDatePeriod.ToString(), normal, 4, 0);


            // DENTFY THE FIRST AND LAST PART NUMBER  FOR DEVIATION  ... cell
            this.addTableCell(table, "IDENTFY THE FIRST AND LAST PART NUMBER  FOR DEVIATION OR IDENTIFY ALTERNATIVE IDENTIFICATION METHOD (For example circle on base of tank - include photo, diagram where applicable) \n Erste Tanknummer ab der Abweichung gilt oder andere Identifikationsmethode zur Rückverfolgung.", normal, 7, 0, "#C4C7C3");


            // DENTFY THE FIRST AND LAST PART NUMBER  FOR DEVIATION value  ... cell
            this.addTableCell(table, deviation.barcode, normal, 7, 0);


            return table;
        }


        /********   add Aprovement to Deivation pdf ****/
        private PdfPTable createApprovementPdf(PdfPTable table, Deviation deviation)
        {

            // Approval cell
            this.addTableCell(table, "APPROVAL \n Prüfer", normalBold, 1, 1, "#99ccff");

            // Name cell
            this.addTableCell(table, "NAME", normalBold, 1, 1, "#99ccff");

            // Approve cell
            this.addTableCell(table, "APPROVE \n Freigabe", normalBold, 1, 1, "#99ccff");

            // Reject cell
            this.addTableCell(table, "REJECT \n Abgelehnt", normalBold, 1, 1, "#99ccff");

            // Comments cell
            this.addTableCell(table, "COMMENTS \n Bemerkungen", normalBold, 1, 1, "#99ccff");

            // Signed cell
            this.addTableCell(table, "SIGNED \n Unterschrift", normalBold, 1, 1, "#99ccff");

            // Signed cell
            this.addTableCell(table, "DATE \n Datum", normalBold, 1, 1, "#99ccff");

            //Get All Approvement
            var approvements = deviation.approvements;
            foreach (var approvement in approvements)
            {             
                      
                    // Approval cell
                    this.addTableCell(table, approvement.approvementGroup.liblle, normal, 1, 0);

                    // Name cell
                    this.addTableCell(table, approvement.name, normal, 1, 0);

                    // Approve cell
                    if (approvement.approved)
                    {
                        this.addTableCell(table);
                    }
                    else
                    {
                        this.addTableCell(table,"", normal, 1, 0);
                    }

                    // Reject cell
                    if (approvement.rejected)
                    {
                        this.addTableCell(table);
                    }
                    else
                    {
                        this.addTableCell(table, "", normal, 1, 0);
                    }

                    // Comments cell
                    this.addTableCell(table, approvement.comment, normal, 1, 0);

                    // Signed cell
                    if (approvement.rejected || approvement.approved)
                    {
                        this.addTableCell(table);
                    }
                    else
                    {
                        this.addTableCell(table, "", normal, 1, 0);
                    }

                    // date cell
                    this.addTableCell(table, approvement.date.ToString(), normal, 1, 0);
                
            }

            
            return table;
        }



        /******** add other(the last part of the deviation)  ****/
        private PdfPTable createDeviationOtherOneTablePdf(PdfPTable table, OtherApprovement otherApprovement)
        {
            // Head cell
            this.addTableCell(table, otherApprovement.title, normalBold, 6, 0, "#FF0000");

            // Yes/No value cell
            this.addTableCell(table, otherApprovement.selectYesNo, normal, 1, 0, "#ff9900");

            // Request Approved value cell
            this.addTableCell(table, "REQUEST APPROVED", small, 1, 0);

            // Request Approved value value cell
            if (otherApprovement.requestApproved)
            {
                this.addTableCell(table);
            }
            else
            {
                this.addTableCell(table, "", small, 1, 0);
            }

            // Name cell
            this.addTableCell(table, "NAME", small, 1, 0);

            // Name value cell
            this.addTableCell(table, otherApprovement.nameApproval, small, 4, 0);

            // REQUEST REJECTED cell
            this.addTableCell(table, "REQUEST REJECTED", small, 1, 0);

            // REQUEST REJECTED value value cell
            if (otherApprovement.requestRejected)
            {
                this.addTableCell(table);
            }
            else
            {
                this.addTableCell(table, "", small, 1, 0);
            }

            // SIGNATURE cell
            this.addTableCell(table, "SIGNATURE", small, 1, 0);

            // SIGNATURE value cell
            this.addTableCell(table, otherApprovement.signatureApproval, small, 4, 0);

            // DATE cell
            this.addTableCell(table, "DATE", small, 1, 0);

            // DATEvalue value cell
            this.addTableCell(table, otherApprovement.date.ToString(), small, 1, 0);

            // POSITION cell
            this.addTableCell(table, "POSITION", small, 1, 0);

            // POSITION value cell
            this.addTableCell(table, otherApprovement.positionApproval, small, 4, 0);



            return table;
        }


        /***** add All approvement table   ****/
        private PdfPTable createAllApprovementTablePdf(PdfPTable table, IList<OtherApprovement> otherApprovements)
        {
            foreach (var otherApprovement in otherApprovements)
            {
                this.createDeviationOtherOneTablePdf(table, otherApprovement);
            }

            return table;
        }


        //add the page foot
        private PdfPTable addPageFoot(Deviation deviation)
        {
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;

            this.addTableCellForPageFoot(table, "Erstellt:A.Manow", small, 1, 0);
            this.addTableCellForPageFoot(table, "Ausgabe D / 20.01.2016", small, 1, 0);
            this.addTableCellForPageFoot(table, deviation.deviationRef, small, 1, 2);

            this.addTableCellForPageFoot(table,this.languageModel.getString("ldigitalSignature"), small, 7, 0);

            return table;
        }

        //to create the hole document
        public String createPdfDeviation(Deviation deviation, IList<OtherApprovement> otherApprovements, String filePath)
        {
            String fileSave = filePath + "/deviation" + deviation.deviationRef + "_" + DateTime.Now.Second.ToString() + ".pdf";
            this.getPdfWriter(fileSave);

            //crate deviation page header
            PdfPTable table = this.generatePageHead();

            //create deviation page content
            this.createDeviationContent(table,deviation);

            //Add approvement Group part to the document
            this.createApprovementPdf(table, deviation);


            //Add Approvement table 
            this.createAllApprovementTablePdf(table, otherApprovements);

            //add page foot
            PdfPTable foot = this.addPageFoot(deviation);
            foot.SpacingBefore = 10;

            // close the document and save it
            doc.Add(table);
            doc.Add(foot);

            doc.Close();

            return fileSave;

        }


    }


}
