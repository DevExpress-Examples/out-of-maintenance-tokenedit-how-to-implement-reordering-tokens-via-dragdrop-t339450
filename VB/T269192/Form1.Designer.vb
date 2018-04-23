Namespace T269192
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.tokenEdit1 = New DevExpress.XtraEditors.TokenEdit()
            DirectCast(Me.tokenEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tokenEdit1
            ' 
            Me.tokenEdit1.Location = New System.Drawing.Point(26, 21)
            Me.tokenEdit1.Name = "tokenEdit1"
            Me.tokenEdit1.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.List
            Me.tokenEdit1.Properties.Separators.AddRange(New String() { ","})
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("January", "1"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("February", "2"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("March", "3"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("April", "4"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("May", "5"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("June", "6"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("July", "7"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("August", "8"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("September", "9"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("October", "10"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("November", "11"))
            Me.tokenEdit1.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("December", "12"))
            Me.tokenEdit1.Size = New System.Drawing.Size(236, 20)
            Me.tokenEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(433, 182)
            Me.Controls.Add(Me.tokenEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.tokenEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents tokenEdit1 As DevExpress.XtraEditors.TokenEdit
    End Class
End Namespace

