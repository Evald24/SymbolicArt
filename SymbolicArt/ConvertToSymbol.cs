using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbolicArt
{
    public static class ConvertToSymbol
    {
        // Стандартная ширина / высота для ASCII-символа
        private const double FontAspectRatio = 0.6;

        // Стандартный набор символов
        private const string OutputCharSet = "##@%=+*:-..1,0";
        private const string HTMLBegin = "<!DOCTYPE html>\n\r    <head>\n\r        <meta charset=\"utf-8\">\n\r        <title>Заголовок</title>\n\r        <style>\n\r            .example {\n\r                font-family:Consolas,monospace;\n\r                font-size:7px;\n\r                white-space: nowrap;\n\r            }\n\r        </style>\n\r    </head>\n\r    <body>\n\r        <p class=\"example\">\n\r";
        private const string HTMLEnd = "   </body>\n\r</html>";

        public static void Generate(string CharSet, Control control, Bitmap bmInput, int outputWidth, bool html)
        {
            Task T = Task.Factory.StartNew(() =>
            {
                control.BeginInvoke(new Action(() =>
                {
                    control.Enabled = false;
                }));
                if (CharSet.Trim() == "")
                    CharSet = OutputCharSet;
                // Группа пикселей ширина / Группа пикселей высота - размер куска пикселей, который будет
                // Группа на 1 символ. Это удваивается, чтобы избежать прогрессивного округление
                double pixelChunkWidth = (double)bmInput.Width / (double)outputWidth;
                double pixelChunkHeight = pixelChunkWidth / FontAspectRatio;

                // Вычисление высоты вывода для захвата всего изображения
                int outputHeight = (int)Math.Round((double)bmInput.Height / pixelChunkHeight);

                // Генерация выходного изображения, строка за строкой
                double pixelOffSetTop = 0.0;
                StringBuilder sbOutput = new StringBuilder();

                    if (html)
                        sbOutput.Append(HTMLBegin);
                for (int row = 1; row <= outputHeight; row++)
                {
                    double pixelOffSetLeft = 0.0;
                    //StringBuilder sbOutput = new StringBuilder();
                    for (int col = 1; col <= outputWidth; col++)
                    {
                        // Расчет яркости для этого набора пикселей путем усреднения
                        // Яркость во всех пикселей в этом фрагменте пикселя
                        double brightSum = 0.0;
                        int pixelCount = 0;
                        for (int pixelLeftInd = 0; pixelLeftInd < (int)pixelChunkWidth; pixelLeftInd++)
                            for (int pixelTopInd = 0; pixelTopInd < (int)pixelChunkHeight; pixelTopInd++)
                            {
                                // Каждый вызов, чтобы получить яркость возвращается значение в диапазоне от 0.0 до 1.0
                                int x = (int)pixelOffSetLeft + pixelLeftInd;
                                int y = (int)pixelOffSetTop + pixelTopInd;
                                if ((x < bmInput.Width) && (y < bmInput.Height))
                                {
                                    brightSum += bmInput.GetPixel(x, y).GetBrightness();
                                    pixelCount++;
                                }
                            }

                        // Средняя яркость для всего этого группы пикселей от 0.0 до 1.0
                        double pixelChunkBrightness = brightSum / pixelCount;

                        // Целевой характер только относительное положение в упорядоченный набор выходных символов
                        int outputIndex = (int)Math.Floor(pixelChunkBrightness * CharSet.Length);
                        if (outputIndex == CharSet.Length)
                            outputIndex--;
                        if (html)
                            if (CharSet[outputIndex] == ' ')
                                sbOutput.Append("&nbsp;");
                            else
                                sbOutput.Append(CharSet[outputIndex]);
                        else
                            sbOutput.Append(CharSet[outputIndex]);

                        pixelOffSetLeft += pixelChunkWidth;
                    }

                    if (html)
                        sbOutput.Append("<br>");

                    sbOutput.AppendLine();
                    //Thread.Sleep(24);
                    pixelOffSetTop += pixelChunkHeight;
                }

                if (html)
                    sbOutput.Append(HTMLEnd);
                    control.BeginInvoke(new Action(() =>
                    {
                        control.Enabled = true;
                        control.Text = sbOutput.ToString();
                    }));
            });
        }

       /* public static void Generate(Form form, object control, Bitmap bmInput, int outputWidth, bool html)
        {
            Task T = Task.Factory.StartNew(() =>
            {
                string CharSet = "";
                if ((form as Main).textBox1.Text.Trim() != "")
                    CharSet = (form as Main).textBox1.Text;
                else
                    CharSet = OutputCharSet;
                // Группа пикселей ширина / Группа пикселей высота - размер куска пикселей, который будет
                // Группа на 1 символ. Это удваивается, чтобы избежать прогрессивного округление
                double pixelChunkWidth = (double)bmInput.Width / (double)outputWidth;
                double pixelChunkHeight = pixelChunkWidth / FontAspectRatio;

                // Вычисление высоты вывода для захвата всего изображения
                int outputHeight = (int)Math.Round((double)bmInput.Height / pixelChunkHeight);

                // Генерация выходного изображения, строка за строкой
                double pixelOffSetTop = 0.0;
                StringBuilder sbOutput = new StringBuilder();

                if (html)
                    sbOutput.Append(HTMLBegin);

                for (int row = 1; row <= outputHeight; row++)
                {
                    double pixelOffSetLeft = 0.0;

                    for (int col = 1; col <= outputWidth; col++)
                    {
                        // Расчет яркости для этого набора пикселей путем усреднения
                        // Яркость во всех пикселей в этом фрагменте пикселя
                        double brightSum = 0.0;
                        int pixelCount = 0;
                        for (int pixelLeftInd = 0; pixelLeftInd < (int)pixelChunkWidth; pixelLeftInd++)
                            for (int pixelTopInd = 0; pixelTopInd < (int)pixelChunkHeight; pixelTopInd++)
                            {
                                // Каждый вызов, чтобы получить яркость возвращается значение в диапазоне от 0.0 до 1.0
                                int x = (int)pixelOffSetLeft + pixelLeftInd;
                                int y = (int)pixelOffSetTop + pixelTopInd;
                                if ((x < bmInput.Width) && (y < bmInput.Height))
                                {
                                    brightSum += bmInput.GetPixel(x, y).GetBrightness();
                                    pixelCount++;
                                }
                            }

                        // Средняя яркость для всего этого группы пикселей от 0.0 до 1.0
                        double pixelChunkBrightness = brightSum / pixelCount;

                        // Целевой характер только относительное положение в упорядоченный набор выходных символов
                        int outputIndex = (int)Math.Floor(pixelChunkBrightness * CharSet.Length);
                        if (outputIndex == CharSet.Length)
                            outputIndex--;
                        if (html)
                            if (CharSet[outputIndex] == ' ')
                                sbOutput.Append("&nbsp;");
                            else
                                sbOutput.Append(CharSet[outputIndex]);
                        else
                            sbOutput.Append(CharSet[outputIndex]);

                        pixelOffSetLeft += pixelChunkWidth;
                    }
                    if (html)
                        sbOutput.Append("<br>");
                    sbOutput.AppendLine();
                    pixelOffSetTop += pixelChunkHeight;
                }

                if (html)
                    sbOutput.Append(HTMLEnd);
                // Возрат изображения в виде текста
                (control as Control).BeginInvoke(new Action(() => { (control as Control).Text += sbOutput.ToString(); }));
            });
        }*/
    }
}