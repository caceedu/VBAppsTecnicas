Public Class FrmUnidades

    Private Sub BtnCalcularVolumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcularVolumen.Click

        Const METROCUBICO As Double = 1000
        Dim dimension, Resul As Double
        Dim volIndex As Integer = CmbVolumen.SelectedIndex

        Select Case volIndex
            Case 0
                'Metros cubicos a litros 
                Try
                    dimension = CDbl(InputBox("Ingrese Metros cubicos (m³)", "m³→L", 1))
                    'Corrección1: Se requiere una revision para posibles caracteres de tipado distinto
                Catch ex As Exception
                    MessageBox.Show("Por favor solo ingrese Numeros", "ERROR | Solo formato numerico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                Resul = dimension * METROCUBICO

                'Mostrar por pantalla en la Label desiganda (LblResVol)
                LblResVol.Text = String.Format("{0:F2} L", dimension)
            Case 1
                Try
                    dimension = CDbl(InputBox("Ingrese Litros (L)", "L → m³", 1))
                Catch ex As Exception
                    MessageBox.Show("Por favor solo ingrese Numeros", "ERROR | Solo formato numerico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                Resul = dimension / METROCUBICO
                LblResVol.Text = String.Format("{0:F2} m³", dimension)
            Case Else
                MessageBox.Show("Selecione una opción de conversión", "ERROR: Selecione una opcion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select


    End Sub
End Class