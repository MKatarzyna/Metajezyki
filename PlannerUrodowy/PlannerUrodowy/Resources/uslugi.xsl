<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="planerUrodowy">
	<html><body>
		<H1>Planer Urodowy</H1>
		<table border="1">
			<xsl:apply-templates select="zadbajO"/>
		</table>
		<table border="1">
			<xsl:apply-templates select="autorzy"/>	
		</table>	
	</body></html>
</xsl:template>

<xsl:template match="zadbajO">
	<h2>Zadbaj o...</h2>
	<xsl:apply-templates select="zabieg"/>
</xsl:template>

<xsl:template match="zabieg">
	<tr>
		<td width="200"><xsl:value-of select="glownaCzescCiala"/> </td>
		<td width="100"><xsl:value-of select="wybranaCzescCiala"/> </td>
		<td width="150"><xsl:value-of select="rodzajZabiegu"/> </td>
		<td width="100"><xsl:value-of select="dataPlanowanegoZabiegu"/> </td>
		<td><xsl:value-of select="opisZabiegu"/> </td>
		<td><xsl:value-of select="kosztZabiegu"/> </td>
	</tr>
</xsl:template>

<xsl:template match="autorzy">
	<h2>Autorzy</h2>
	<xsl:apply-templates select="autor"/>
</xsl:template>


<xsl:template match="autor">
	<tr>
		<td><xsl:value-of select="imie"/></td>
		<td><xsl:value-of select="nazwisko"/></td>
		<td><xsl:value-of select="adres"/></td>
		<td><xsl:value-of select="mail"/></td>
	</tr>	
</xsl:template>	
	
</xsl:stylesheet>