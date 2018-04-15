<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Prestamos de Libros</h2>
        <table>
          <tr bgcolor="#1FC533">
            <th colspan="2">Prestamo</th>
          </tr>

          <tr>
            <td>Código:</td>
            <td>
              <xsl:value-of select="Prestamos/Prestamo/Codigo"/>
            </td>
          </tr>
          <tr>
            <td>Fecha de Solicitud:</td>
            <td>
              <xsl:value-of select="Prestamos/Prestamo/Fecha_Emision"/>
            </td>
          </tr>
          <tr>
            <td>Fecha de Devolucion:</td>
            <td>
              <xsl:value-of select="Prestamos/Prestamo/Fecha_Devolucion"/>
            </td>
          </tr>
          <tr>
            <td>Días de Prestamo:</td>
            <td>
              <xsl:value-of select="Prestamos/Prestamo/Dias_Prestamo"/>
            </td>
          </tr>
          <tr bgcolor="#1FC533">
            <th colspan="2">Usuario Autorizado</th>
            <tr>
              <td>Usuario:</td>
              <td>
                <xsl:value-of select="Prestamos/Prestamo/Usuario_Autorizado"/>
              </td>
            </tr>
            <tr>
              <td>Tipo:</td>
              <td>
                <xsl:value-of select="Prestamos/Prestamo/Roll_Usuario"/>
              </td>
            </tr>
          </tr>

          <tr bgcolor="#1FC533">
            <th colspan="2">Estudiante</th>
          </tr>
          <tr>
            <td>Cédula:</td>
            <td colspan="2">
              <xsl:value-of select="Prestamos/Estudiante/Cedula"/>
            </td>
          </tr>

          <tr>
            <td>Nombre:</td>
            <td colspan="2">
              <xsl:value-of select="Prestamos/Estudiante/Nombre"/>
            </td>
          </tr>

          <tr>
            <td>Sección:</td>
            <td colspan="2">
              <xsl:value-of select="Prestamos/Estudiante/Seccion"/>
            </td>
          </tr>

          <tr>
            <td>Teléfono</td>
            <td colspan="2">
              <xsl:value-of select="Prestamos/Estudiante/Telefono"/>
            </td>
          </tr>

          <tr>
            <td>Email:</td>
            <td colspan="2">
              <xsl:value-of select="Prestamos/Estudiante/Email"/>
            </td>
          </tr>

          <xsl:for-each select="Prestamos/Libros/Libro">
            <tr bgcolor="#1FC533">
              <th colspan="2">Libro</th>
            </tr>

            <tr>
              <td>Código:</td>
              <td colspan="2">
                <xsl:value-of select="./Codigo"/>
              </td>
            </tr>

            <tr>
              <td>Título:</td>
              <td colspan="2">
                <xsl:value-of select="./Titulo"/>
              </td>
            </tr>

            <tr>
              <td>Año:</td>
              <td colspan="2">
                <xsl:value-of select="./Año"/>
              </td>
            </tr>

            <tr>
              <td>Editorial</td>
              <td colspan="2">
                <xsl:value-of select="./Editorial"/>
              </td>
            </tr>

          </xsl:for-each>

          <tr bgcolor="#1FC533">
            <th colspan="2">Tipo de Solicitud</th>
            <tr>
              <td>Clasificación:</td>
              <td>
                <xsl:value-of select="Prestamos/Libros/Tipo_Solicitud"/>
              </td>
            </tr>
          </tr>

        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>