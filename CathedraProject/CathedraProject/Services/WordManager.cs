using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CathedraProject
{
    public static class WordManager
    {
        public static void Export(Student student, string filename)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filename, true))
            {
                var contentControls = wordDoc.MainDocumentPart.Document.Descendants<SdtElement>();

                foreach (var item in contentControls)
                {
                    string tag = item.SdtProperties.GetFirstChild<Tag>().Val.Value;

                    Text text = item.Descendants<Text>().First();
                    foreach (var itemText in item.Descendants<Text>())
                    {
                        itemText.Text = "";
                    }

                    switch (tag)
                    {
                        case "_codeDirection":
                            text.Text = student.Direction.Code;
                            break;
                        case "_nameDirection":
                            text.Text = student.Direction.Name;
                            break;
                        case "_surname":
                            text.Text = student.LastName;
                            break;
                        case "_name":
                            text.Text = student.FirstName;
                            break;
                        case "_middleName":
                            text.Text = student.MiddleName;
                            break;
                        case "_sex":
                            text.Text = student.SexString;
                            break;
                        case "_birthday":
                            text.Text = student.Birthday.ToShortDateString();
                            break;
                        case "_city":
                            text.Text = student.Address?.City;
                            break;
                        case "_education":
                            text.Text = student.Education;
                            break;
                        case "_placeWork":
                            text.Text = student.PlaceWork;
                            break;
                        case "_address":
                            text.Text = student.Address?.ToString();
                            break;
                        case "_phone":
                            text.Text = student.Phone;
                            break;
                        case "_statusFamily":
                            text.Text = student.StatusFamily;
                            break;
                        case "_fatherFIO":
                            text.Text = student.Father?.FIO;
                            break;
                        case "_fatherBirtday":
                            text.Text = student.Father?.Birthday.Year.ToString();
                            break;
                        case "_fatherPlaceWork":
                            text.Text = student.Father?.Work;
                            break;
                        case "_fatherWorkPost":
                            text.Text = student.Father?.Position;
                            break;
                        case "_fatherAddress":
                            text.Text = student.Father?.Address?.ToString();
                            break;
                        case "_fatherPhone":
                            text.Text = student.Father?.Phone;
                            break;
                        case "_fatherPhoneHome":
                            text.Text = student.Father?.HomeNumb;
                            break;
                        case "_fatherEmail":
                            text.Text = student.Father?.Email;
                            break;
                        case "_motherFIO":
                            text.Text = student.Mother?.FIO;
                            break;
                        case "_motherBirtday":
                            text.Text = student.Mother?.Birthday.Year.ToString();
                            break;
                        case "_motherPlaceWork":
                            text.Text = student.Mother?.Work;
                            break;
                        case "_motherWorkPost":
                            text.Text = student.Mother?.Position;
                            break;
                        case "_motherAddress":
                            text.Text = student.Mother?.Address?.ToString();
                            break;
                        case "_motherPhone":
                            text.Text = student.Mother?.Phone;
                            break;
                        case "_motherPhoneHome":
                            text.Text = student.Mother?.HomeNumb;
                            break;
                        case "_motherEmail":
                            text.Text = student.Mother?.Email;
                            break;
                        case "_status":
                            text.Text = student.StatusFamily;
                            break;
                        case "_activity":
                            text.Text = student.Activity;
                            break;
                        case "_dateCreate":
                            text.Text = student.CreateDate.ToShortDateString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
