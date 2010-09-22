<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:fo="http://www.w3.org/1999/XSL/Format"
                xmlns:mml="http://www.w3.org/1998/Math/MathML"
                version="1.0">
                
<xsl:import href="xsl/html/chunkfast.xsl"/>
<xsl:param name="admon.graphics">1</xsl:param>
<xsl:param name="admon.graphics.path">../images/resources/</xsl:param>
<xsl:param name="admon.graphics.extension">.png</xsl:param>
<xsl:param name="generate.toc" select="'book toc'"/>
<xsl:param name="use.extensions" >1</xsl:param>
<xsl:param name="graphicsize.extension">1</xsl:param>
<xsl:param name="textinsert.extension">1</xsl:param>
<xsl:param name="body.start.indent">0.25in</xsl:param>
<xsl:param name="alignment">justify</xsl:param>
<xsl:param name="hyphenate">true</xsl:param>
<xsl:param name="use.id.as.filename">1</xsl:param>
<xsl:param name="chunk.first.sections">1</xsl:param>
<xsl:attribute-set name="blockquote.properties">
  <xsl:attribute name="hyphenate">false</xsl:attribute>
</xsl:attribute-set>

<xsl:param name="bibliography.collection">file://../plainbook/biblio.xml</xsl:param>
<xsl:param name="bibliography.numbered">1</xsl:param>

<xsl:param name="local.l10n.xml" select="document('')" />
	<l:i18n xmlns:l="http://docbook.sourceforge.net/xmlns/l10n/1.0">
		<l:l10n language="en">
			<l:gentext key="hyphenation-push-character-count" text="3"/>
			<l:gentext key="hyphenation-remain-character-count" text="4"/>
			<l:context name="index">
				<l:template name="term-separator" text=" "/>
			</l:context>
			<l:context name="xref">
				<l:template name="section" text="%t" />
			</l:context>
		</l:l10n>
		</l:i18n>
</xsl:stylesheet>
