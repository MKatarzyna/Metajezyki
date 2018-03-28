<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>

   <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="/">
    <html>
      <body>
            <h3><a href="uslugi.xml">Uslugi</a></h3>
            <h2>Porady</h2>
			<table id="myTable">
                <tr bgcolor="#9acd32">
                
                <th class="table-head"><p>Narodowosc</p></th>
                <th class="table-head"><p>Narodowosc</p></th>
                    
                </tr>
				<xsl:for-each select="document('porady.xml')/planerUrodowy/porady/porada">
				<tr>
			  
                    <td>
                        <xsl:value-of select="wybranaCzescCiala"/>
                    </td>

                    <td>
                        <xsl:value-of select="opisPorady"/>
                    </td>
                
                </tr>
			    </xsl:for-each>
		    </table>
            <style>
                table {
                    margin: 0 auto;
                }

                tr:nth-child(2n) {
                    background-color: #bbb;
                }
                tr:nth-child(2n - 1) {
                    background-color: #eee;
                }

                td {
                    padding: 8px;
                }
            </style>
     </body>
    </html>
  </xsl:template>



</xsl:stylesheet>