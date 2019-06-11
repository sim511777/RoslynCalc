using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoslynCalc {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private async void Eval() {
         string exp = this.tbxExpression.Text;
         string output = string.Empty;
         try {
            object res = await CSharpScript.EvaluateAsync(exp);
            output = exp + " = " + res.ToString();
         } catch (Exception ex) {
            output = exp + " = " + ex.Message;
         }
         this.lbxResult.Items.Insert(0, output);
         this.tbxExpression.Clear();
      }

      private void tbxExpression_KeyDown(object sender, KeyEventArgs e) {
         if (e.KeyCode == Keys.Enter) {
            this.Eval();
         }
      }

      private void lbxResult_SelectedIndexChanged(object sender, EventArgs e) {
         string text = this.lbxResult.SelectedItem.ToString();
         string exp = text.Split(new string[]{" = "}, StringSplitOptions.None)[0];
         this.tbxExpression.Text = exp;
      }
   }
}
