using System;
using System.Collections.Generic;
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

namespace MineSweeper
{
    ///// <summary>
    ///// このカスタム コントロールを XAML ファイルで使用するには、手順 1a または 1b の後、手順 2 に従います。
    /////
    ///// 手順 1a) 現在のプロジェクトに存在する XAML ファイルでこのカスタム コントロールを使用する場合
    ///// この XmlNamespace 属性を使用場所であるマークアップ ファイルのルート要素に
    ///// 追加します:
    /////
    /////     xmlns:MyNamespace="clr-namespace:MineSweeper"
    /////
    /////
    ///// 手順 1b) 異なるプロジェクトに存在する XAML ファイルでこのカスタム コントロールを使用する場合
    ///// この XmlNamespace 属性を使用場所であるマークアップ ファイルのルート要素に
    ///// 追加します:
    /////
    /////     xmlns:MyNamespace="clr-namespace:MineSweeper;assembly=MineSweeper"
    /////
    ///// また、XAML ファイルのあるプロジェクトからこのプロジェクトへのプロジェクト参照を追加し、
    ///// リビルドして、コンパイル エラーを防ぐ必要があります:
    /////
    /////     ソリューション エクスプローラーで対象のプロジェクトを右クリックし、
    /////     [参照の追加] の [プロジェクト] を選択してから、このプロジェクトを参照し、選択します。
    /////
    /////
    ///// 手順 2)
    ///// コントロールを XAML ファイルで使用します。
    /////
    /////     <MyNamespace:AnyKeyClikedButton/>
    /////
    ///// </summary>
    
    /// <summary>
    /// マウスの右クリック、ホイールクリックに対応したボタンです
    /// </summary>
    public class AnyKeyClikedButton : Button
    {
        static AnyKeyClikedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnyKeyClikedButton), new FrameworkPropertyMetadata(typeof(AnyKeyClikedButton)));
        }


        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            //base.OnMouseDown(e);

            IsPressed = true;
        }

        protected override void OnPreviewMouseUp(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Released &&
            e.LeftButton == MouseButtonState.Released)
            {

                IsPressed = false;
            }
        }
    }
}
