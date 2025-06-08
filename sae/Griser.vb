Module Griser

    Friend Function GriserImage(source As Image) As Image
        Dim bmp As New Bitmap(source.Width, source.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim colorMatrix As New Imaging.ColorMatrix({
        New Single() {0.3, 0.3, 0.3, 0, 0},
        New Single() {0.59, 0.59, 0.59, 0, 0},
        New Single() {0.11, 0.11, 0.11, 0, 0},
        New Single() {0, 0, 0, 1, 0},
        New Single() {0, 0, 0, 0, 1}
    })

        Dim attributes As New Imaging.ImageAttributes()
        attributes.SetColorMatrix(colorMatrix)

        g.DrawImage(source,
                New Rectangle(0, 0, bmp.Width, bmp.Height),
                0, 0, source.Width, source.Height,
                GraphicsUnit.Pixel, attributes)

        g.Dispose()
        attributes.Dispose()

        Return bmp
    End Function

End Module
