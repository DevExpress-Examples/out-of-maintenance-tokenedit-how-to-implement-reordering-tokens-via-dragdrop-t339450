using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T269192 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            tokenEdit1.MouseMove += tokenEdit1_MouseMove;
            tokenEdit1.MouseDown += tokenEdit1_MouseDown;
            tokenEdit1.AllowDrop = true;
        }

        void tokenEdit1_MouseDown(object sender, MouseEventArgs e) {
            tokenEditToken = tokenEdit1.CalcHitInfo(e.Location);
        }

        void tokenEdit1_MouseMove(object sender, MouseEventArgs e) {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                tokenEdit1.DoDragDrop(tokenEditToken,DragDropEffects.Move);
            }
        }
        private TokenEditHitInfo tokenEditToken;

        private void tokenEdit1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }

        private void tokenEdit1_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }

        private void tokenEdit1_DragDrop(object sender, DragEventArgs e) {
            TokenEditHitInfo token = (TokenEditHitInfo)e.Data.GetData(typeof(TokenEditHitInfo));
            var allTokens = tokenEdit1.GetTokenList();
            var newPl = tokenEdit1.CalcHitInfo(tokenEdit1.PointToClient(new Point(e.X, e.Y)));
            if(!newPl.InToken && newPl.InEditorRect) {
                var values = (IList)tokenEdit1.EditValue;
                values.Remove(token.Token.Value.ToString());
                values.Add(token.Token.Value.ToString());
                tokenEdit1.EditValue = values;
            } else if(newPl.InToken) {
                var hitPoint = ((DevExpress.XtraEditors.ViewInfo.EditHitInfo)(newPl)).HitPoint.X;

                var tokenStartX = newPl.TokenInfo.Bounds.X;
                var tokenEndX = newPl.TokenInfo.Bounds.X + newPl.TokenInfo.Bounds.Width;
                bool before = hitPoint - tokenStartX < tokenEndX - hitPoint;
                var values = (IList)tokenEdit1.EditValue;
                values.Remove(token.Token.Value.ToString());
                int index = values.IndexOf(newPl.Token.Value);
                values.Insert(before ? index : index +1, token.Token.Value.ToString());
            }
        }
    }
}
