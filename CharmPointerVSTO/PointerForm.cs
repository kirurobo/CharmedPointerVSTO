using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharmPointerVSTO
{
    public partial class PointerForm : Form
    {
        /// <summary>
        /// 座標の基準点
        /// デフォルトは中央
        /// </summary>
        public System.Drawing.Point Origin;

        public Rectangle SlideWindowRectangle;
        public Rectangle PreviewWindowRectangle;
        public bool HasPreview;


        public PointerForm()
        {
            InitializeComponent();

            Initialize();    // 独自要素の初期化
        }

        private void Initialize()
        {
            Origin = new Point(Width / 2, Height / 2);
        }

        /// <summary>
        /// 画面上での座標を設定
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetPosition(float x, float y)
        {
            Left = (int)x - Origin.X;
            Top = (int)y - Origin.Y;
        }

        /// <summary>
        /// 画面上での座標を設定
        /// </summary>
        /// <param name="position"></param>
        public void SetPosition(Point position)
        {
            SetPosition(position.X, position.Y);
        }

        /// <summary>
        /// 一定周期での呼び出し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerForMainLoop_Tick(object sender, EventArgs e)
        {
            UpdatePointer();
        }


        private void UpdatePointer()
        {
            var pos = Control.MousePosition;

            // もしPowerPointのプレビューがあった場合
            if (HasPreview) {
                // スライショー領域にマウスがなく、かつ、プレビュー領域にあれば、座標を変換
                if (!SlideWindowRectangle.Contains(pos) && PreviewWindowRectangle.Contains(pos)) {
                    int px = PreviewWindowRectangle.X;
                    int py = PreviewWindowRectangle.Y;
                    Point newPos = new Point(
                        (pos.X - px) * SlideWindowRectangle.Width / PreviewWindowRectangle.Width + SlideWindowRectangle.X,
                        (pos.Y - py) * SlideWindowRectangle.Height / PreviewWindowRectangle.Height + SlideWindowRectangle.Y
                        );
                    pos = newPos;
                }
            }

            SetPosition(pos);
        }
    }
}
