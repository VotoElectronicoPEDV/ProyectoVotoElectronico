Module ConversionDeImagen
    Public Function ImagenToByte(ByVal img As Image) As Byte()
        Dim ms As New IO.MemoryStream
        img.Save(ms, img.RawFormat)
        ImagenToByte = ms.GetBuffer
    End Function

End Module
