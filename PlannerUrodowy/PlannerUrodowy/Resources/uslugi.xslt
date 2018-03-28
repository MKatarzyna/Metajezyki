<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

<xsl:variable name="UslugiTable">
	<tr bgcolor="#02e683">
		<th style="text-align:left"><a href="JavaScript:reSort('glownaCzescCiala')">Glowna część ciala</a></th>
		<th style="text-align:left"><a href="JavaScript:reSort('wybranaCzescCiala')">Wybrana czesc ciala</a></th>
		<th style="text-align:left">Rodzaj zabiegu</th>
        <th style="text-align:left">Data planowania zabiegu</th>
	    <th style="text-align:left">Opis zabiegu</th>
	    <th style="text-align:left">Koszt zabiegu</th>
            
	</tr>
</xsl:variable>

<xsl:param name="sortKey">nazwa</xsl:param>
<xsl:param name="sortOrder">ascending</xsl:param>
<xsl:param name="sortType">text</xsl:param>

<xsl:template match="/">
	<html>
		<body id="disp">
			<script type="text/javascript" src="sortXML.js"></script>
            <h3><a href="porady.xml">Porady</a></h3>
			<h2>Zadbaj o...</h2>
			<table>
				<xsl:copy-of select="$UslugiTable"/>

				<xsl:for-each select="document('uslugi.xml')/planerUrodowy/zadbajO/zabieg">
				<xsl:sort select="*[name(.)=$sortKey]|@*[name(.)=$sortKey]" order="{$sortOrder}" data-type="{$sortType}"/>
				<tr>
			  
                    <td>
                        <xsl:value-of select="glownaCzescCiala"/>
                    </td>

                    <td>
                        <xsl:value-of select="wybranaCzescCiala"/>
                    </td>

                    <td>
                        <xsl:value-of select="rodzajZabiegu"/>
                    </td>

                    <td>
                        <xsl:value-of select="dataPlanowanegoZabiegu"/>
                    </td>

                    <td>
                        <xsl:value-of select="opisZabiegu"/>
                    </td>

                    <td>
                        <xsl:value-of select="kosztZabiegu"/>
                    </td>
                
                </tr>
			    </xsl:for-each>
		    </table>

            <!-- <h2>Porady</h2>
			<table>
				<xsl:copy-of select="$PoradyTable"/>

				<xsl:for-each select="document('porady.xml')/planerUrodowy/porady/porada">
				<xsl:sort select="*[name(.)=$sortKey]|@*[name(.)=$sortKey]" order="{$sortOrder}" data-type="{$sortType}"/>
				<tr>
			  
                    <td>
                        <xsl:value-of select="wybranaCzescCiala"/>
                    </td>

                    <td>
                        <xsl:value-of select="opisPorady"/>
                    </td>
                
                </tr>
			    </xsl:for-each>
		    </table> -->
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