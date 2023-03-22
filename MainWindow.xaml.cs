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
        public StringBuilder st = new StringBuilder();
        public void concat()
        {
            st.Append("; Начало оптимизации прорисовки кабелей по трубам\r\n\t\t\t" +
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


        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void save_b_Click(object sender, RoutedEventArgs e)
        {



            const string caption = "Error!";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "LSP Files(*.lsp)|*.lsp|All(*.*)|*";
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = dialog.FileName;


            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
                StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.GetEncoding(1251));
            }
        }
    }
    }
