using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace _22_03_2023_WPF_kable_lisp_circle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        //   public StringBuilder st = new StringBuilder();
      public  List<string> list_name = new List<string>();
        public string kable_d_l;
        public void concat()
        {
            kable_d_l = ("; Начало оптимизации прорисовки кабелей по трубам\r\n\t\t\t" +
                 "; 1) Добавление слоев 19.03.2019\r\n" +
                 "(DEFUN c:Tald_kable_diam (/ x1 y1 y2 y3 circl circl2 circl3 name3 last1 dpat S1 S2 " +
                 "\r\n                          " +
                 "lay N_lay explanation\r\n                         ) \r\n  " +
                 "(vl-load-com) ; подключаем ActiveX для создания слоев и в последующем примечаний/////----" +
                 "\r\n  (command \"_OSMODE\" \"0\") ; отключение режима 2D привязка\r\n  " +
                 "(initget 133) ; ограничения ввода данных 1 пустой ввод + 4 ввод отриц чисел 128 произвольный ввод;разрешен 2 ввод нуля и полож знач\r\n " +
                 " (setq y1 (getreal \"введите Y: \")) " +
                 ";координата Y\r\n  " +
                 "(setq x1 (getreal \"введите X: \")) " +
                 ";координата X\r\n" +
                 "  (setq radpat (getreal \"введите радиус патрубка: \")) ;радиус патрубка\r\n" +
                 "  (setq megos (getreal \"введите межосевое расстояние: \"))\r\n" +
                 "  ; межосевое расстояние  отрисовка вверх потом доделаю отрисовка вправо с переносом вниз\r\n" +
                 "  ;межосевое расстояние\r\n" +
                 "  (setq y2 0) ; вспомогательная\r\n" +
                 "  (setq y3 0) ; вспомогательная\r\n" +
                 "  (setq x2 0) ; вспомогательная\r\n" +
                 "  (setq last1 0) ; вспомогательная\r\n" +
                 "  (setq circl 0) ; вспомогательная радиусы\r\n" +
                 "  (setq circl2 0) ; вспомогательная\r\n" +
                 "  (setq circl3 0) ; вспомогательная список диаметров\r\n" +
                 "  (setq name3 0) ; вспомогательная список названий кабеля\r\n" +
                 "  (setq S1 0) ; площадь кабеля\r\n" +
                 "  (setq S2 0) ; площадь трубы\r\n" +
                 "  (setq N_lay 0) ; номер кабеля из списка слоев\r\n" +
                 "  (setq lay 0) ; имя для создания текущего слоя (Обозначение кабеля. провода)\r\n" +
                 "  (setq explanation 1) ; пояснение для слоя - а так номер трубы\r\n  " +
                 "_______________________________________________________________________________\r\n " +
                 " (foreach circl3 \r\n  " +
                 "  '(; Список диаметров берем из кабельного журнала - впоследствии база данных ");
            // вставыляем данные из texbox2 - диаметры
            kable_d_l += "\n" + textbox2.Text + " ";
            kable_d_l += " \n )" + "\n" + " (setq lay(nth N_lay'(";

            // цикл с именами из texbox1 вставить и добавить кавычки " + name + "

            kable_d_l += "\"dfd\"\n";
            // пробуем через спеисок перебрать texbox1

            kable_d_l += ")\n";
            kable_d_l += ")\n";
    kable_d_l += ")\n";

  kable_d_l += "(command \"_.-layer\" \"_m\" lay \"\") ; создаем слои на основе списка \"nth N_lay\" и делаем его текущим для именования кабеля\n";
  kable_d_l += "  (setq circl(/ circl3 2))\n";
            kable_d_l += " ; преобразуем диаметр в радиус ВНИМАНИЕ ПРОГРАММА РАБОТАЕТ С РАДИУСАМИ\n";
            kable_d_l += "(setq S1(* 3.14(* circl circl)))\n";
    kable_d_l += "(setq x2(+ last1 circl))\n";
            kable_d_l += "; складываем настоящий и преведущий радиус\n";
    kable_d_l += "(setq x1(+ x2 x1)); координата по X\n";
            kable_d_l += " (if (> last1 circl)\n";
            kable_d_l += "  ; last1 > circl; то y2 = last1 т.е преведущий диаметр.Отступаем по Y по максимальному диаметру\n";
            kable_d_l += "  (setq y2 (* 2 last1))\n";
            kable_d_l += "  ; при переборе радиусов из списка.Переменная circl\n";
            kable_d_l += ")\n";
    kable_d_l += "(if (> circl last1)\n ";
    kable_d_l += "  ; last1 > circl; то y2 = last1 т.е преведущий диаметр.Отступаем по Y по максимальному диаметру\n";
    kable_d_l += "  (setq y2 (* 2 circl))\n";
    kable_d_l += "  ; при переборе радиусов из списка.Переменная circl\n";
    kable_d_l += ")\n";
    kable_d_l += "(if (>= x1 radpat) \n";
    kable_d_l += "  ; ; ограничение кабеля по X\n";
    kable_d_l += "  (progn\n";
    kable_d_l += "    (setq y1 (+ y2 y1))\n";
    kable_d_l += "    ; ; увеличиваем Y на диаметр кабеля(*2 last1)\n";
    kable_d_l += "    (setq y3(+ y2 y3))\n";
    kable_d_l += "    (setq x1 0)\n";
    kable_d_l += "  )\n";
    kable_d_l += ")\n";
    kable_d_l += ";description\n";
    kable_d_l += "      ; (if (>= circl 13.0)\n";
    kable_d_l += "; ; максимальный диаметр одного кабеля\n";
    kable_d_l += "; (progn\n";
    kable_d_l += "; (setq y3 circl)\n";
    kable_d_l += "; (setq y1(+ megos(- y1 y2)))\n";
    kable_d_l += "; (setq x1 0)\n";
    kable_d_l += "; (setq explanation(+ 1 explanation))\n";
    kable_d_l += "; ; пояснение для слоя - а так номер трубы увеличиваем на 1 при переходе в другой патрубок\n";
    kable_d_l += ";       )\n";
    kable_d_l += ";     )\n";
    kable_d_l += ";\n";
    kable_d_l += "        (if (>= y3 radpat) \n";
    kable_d_l += "  ; переход по Y межосевое\n";
    kable_d_l += "  (progn\n";
    kable_d_l += "    (setq y1 (+ megos(- y1 y3)))\n";
    kable_d_l += "    (setq y3 0)\n";
    kable_d_l += "    (setq x1 0)\n";
    kable_d_l += "    (setq explanation(+ 1 explanation))\n";
    kable_d_l += "    ; пояснение для слоя - а так номер трубы увеличиваем на 1 при переходе в другой патрубок\n";
    kable_d_l += "  )\n";
    kable_d_l += ")\n";
    kable_d_l += "(print y1)\n";
    kable_d_l += "(print y3)\n";
    kable_d_l += "(print x1)\n";
    kable_d_l += "; (vla - put - description\n";
    kable_d_l += "; (vlax - ename->vla - object(tblobjname \"LAYER\" lay))\n";
    kable_d_l += "; explanation\n";
    kable_d_l += "; ) ; для создания примечаний** пока не используем\n";
    kable_d_l += "; ; ; (command \"_point\"(list x1 y1))\n";
    kable_d_l += "; ; ; ; Черчение точки; перебор 1 - 861\n";
    kable_d_l += "; ; ; (command\n";
    kable_d_l += "; ; ; \"_text\"\n";
            kable_d_l += "; ; ; (list x1 y1)\n";
    kable_d_l += "; ; ; \"1\"\n";
    kable_d_l += "; ; ; \"0\"\n";
    kable_d_l += "; ; ; (rtos circl3 2 2)\n";
    kable_d_l += "; ; ; \"\"\n";
    kable_d_l += "; ; ;    )\n";
    kable_d_l += "; Черчение диаметра по списку; перебор 1 - 861\n";
    kable_d_l += "(command \"_circle\"(list x1 y1) circl)\n";
    kable_d_l += "; Черчение кабелей по списку; перебор 1 - 861\n";
    kable_d_l += "(setq last1 circl)\n";
    kable_d_l += "; присваемаем значение отрисованного круга для сложения с радиусом нового круга\n";
    kable_d_l += "(setq N_lay (+ 1 N_lay)) ; следующий по списку слоев идем от нуля \"0\" нуль - это первый из списка\n";
    kable_d_l += "(prin1 lay)\n";
  kable_d_l += ")\n";

  kable_d_l += "________________________________________________________________________________________\n";
  kable_d_l += "(alert \"Закончили\")\n";
  kable_d_l += "(command \"_OSMODE\" \"5887\")\n";
  kable_d_l += "; включение режима 2D привязка\n";
kable_d_l += ")\n";
           

        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)

        {

        }

        private void save_b_Click(object sender, RoutedEventArgs e)
        {
            concat();

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "LSP Files(*.lsp)|*.lsp|All(*.*)|*";
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = dialog.FileName;

            try
            {
                if (dialog.ShowDialog() == true)
                {
                    string path = dialog.FileName;
                    StreamWriter sw = new StreamWriter(path, true);
                    using (sw)
                    { sw.Write(kable_d_l); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
