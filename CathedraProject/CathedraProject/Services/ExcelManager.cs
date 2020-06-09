using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CathedraProject.Services
{
    public static class ExcelManager
    {
        public static void ExportStudents(string filename, List<Student> students)
        {
            Excel.Application ex = new Excel.Application();
            //Отобразить Excel
            ex.Visible = false;
            //Количество листов в рабочей книге
            ex.SheetsInNewWorkbook = 1;
            //Добавить рабочую книгу
            Excel.Workbook workBook = ex.Workbooks.Add();

            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

            string[] headers = { "ФИО", "Направление", "Группа", "Курс", "Дата рождения", "Телефон", "Email" };
            for (int i = 0; i < headers.Length; i++)
            {
                sheet.Cells[1, i + 1] = headers[i];
            }

            for (int i = 0; i < students.Count; i++)
            {
                sheet.Cells[i + 2, 1] = students[i].FIO;
                sheet.Cells[i + 2, 2] = students[i].Direction.Name;
                sheet.Cells[i + 2, 3] = students[i].Group.Name;
                sheet.Cells[i + 2, 4] = students[i].Course;
                sheet.Cells[i + 2, 5] = students[i].Birthday;
                sheet.Cells[i + 2, 6] = students[i].Phone;
                sheet.Cells[i + 2, 7] = students[i].Email;
            }

            Excel.Range range = sheet.UsedRange;

            range.Cells.Font.Size = 14;

            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;

            range.EntireColumn.AutoFit();
            range.EntireRow.AutoFit();

            workBook.Close(true, filename);
            ex.Quit();
        }
    }
}
