<xsl:stylesheet 
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
   version="1.0"
>
  <xsl:output encoding="UTF-8" method="xml" indent="no" 
  media-type="text/xml; charset=UTF-8" omit-xml-declaration="no"
  cdata-section-elements="programlisting"
  />
<xsl:strip-space elements="*" />
<xsl:template match="/"><xsl:apply-templates /></xsl:template>

<xsl:template match="try">
<section>
<xsl:if test="@id"><xsl:attribute name="id"><xsl:value-of select="@id" /></xsl:attribute></xsl:if>
<title>Try this: <xsl:value-of select="@title"/></title>
<para><emphasis>When: <xsl:value-of select="@context" /></emphasis></para>
<xsl:if test="@benefit"><para><emphasis>In order to: <xsl:value-of select="@benefit" /></emphasis></para></xsl:if>
	<xsl:apply-templates />
</section>
</xsl:template>

<xsl:template match="try-vip">
<section>
<xsl:if test="@id"><xsl:attribute name="id"><xsl:value-of select="@id" /></xsl:attribute></xsl:if>
<title>Try this (VIP): <xsl:value-of select="@title"/></title>
<xsl:if test="@benefit"><para><emphasis>In order to: <xsl:value-of select="@benefit" /></emphasis></para></xsl:if>
	<xsl:apply-templates />
</section>
</xsl:template>

<xsl:template match="avoid">
<section>
<xsl:if test="@id"><xsl:attribute name="id"><xsl:value-of select="@id" /></xsl:attribute></xsl:if>
<title>Avoid this: <xsl:value-of select="@title"/></title>
<para><emphasis>When: <xsl:value-of select="@context" /></emphasis></para>
<xsl:if test="@benefit"><para><emphasis>In order to: <xsl:value-of select="@benefit" /></emphasis></para></xsl:if>
	<xsl:apply-templates />
</section>
</xsl:template>

<xsl:template match="avoid-vip">
<section>
<xsl:if test="@id"><xsl:attribute name="id"><xsl:value-of select="@id" /></xsl:attribute></xsl:if>
<title>Avoid this (VIP): <xsl:value-of select="@title"/></title>
<xsl:if test="@benefit"><para><emphasis>In order to: <xsl:value-of select="@benefit" /></emphasis></para></xsl:if>
	<xsl:apply-templates />
</section>
</xsl:template>

<xsl:template match="preface|appendix|chapter|section|note|important|sidebar|tip|colophon">
<xsl:copy>
<xsl:if test="@id"><xsl:attribute name="id"><xsl:value-of select="@id" /></xsl:attribute></xsl:if>
<title><xsl:value-of select="@title"/></title>
	<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="link">
<xref><xsl:attribute name="linkend"><xsl:value-of select="@ref" /></xsl:attribute></xref>
</xsl:template>
<xsl:template match="p"><para><xsl:apply-templates /></para></xsl:template>
<xsl:template match="code">
	<xsl:choose>
	<xsl:when test="ancestor::p or ancestor::li"><code><xsl:apply-templates /></code></xsl:when>
	<xsl:otherwise>
		<xsl:choose>
		<xsl:when test="@file">
			<programlisting><inlinemediaobject><textobject>
		 <textdata format='linespecific'><xsl:attribute name="fileref">../resources/src/<xsl:value-of select="@file" />.<xsl:choose><xsl:when test="@part"><xsl:value-of select="@part"/></xsl:when><xsl:otherwise>full</xsl:otherwise></xsl:choose></xsl:attribute></textdata></textobject>
		  </inlinemediaobject></programlisting>
		</xsl:when>
	<xsl:otherwise><programlisting><xsl:apply-templates /></programlisting></xsl:otherwise></xsl:choose>
	</xsl:otherwise>
</xsl:choose>
</xsl:template>
<xsl:template match="ol">
<orderedlist><xsl:apply-templates /></orderedlist>
</xsl:template>
<xsl:template match="ul">
<itemizedlist><xsl:apply-templates /></itemizedlist>
</xsl:template>
<xsl:template match="li">
<listitem><para><xsl:apply-templates /></para></listitem>
</xsl:template>

<xsl:template match="footnote">
<footnote><para><xsl:apply-templates /></para></footnote>
</xsl:template>
<xsl:template match="url">
<xsl:choose>
<xsl:when  test="@title and ancestor::footnote">
<xsl:value-of select="@title"/> 
(<ulink><xsl:attribute name="url"><xsl:value-of select="@link"/></xsl:attribute></ulink>)
</xsl:when>
<xsl:when test="@title">
<emphasis><xsl:value-of select="@title"/></emphasis><footnote><para>
<ulink><xsl:attribute name="url"><xsl:value-of select="@link"/></xsl:attribute></ulink>
</para></footnote>
</xsl:when>
<xsl:otherwise>
<ulink><xsl:attribute name="url"><xsl:value-of select="@link"/></xsl:attribute></ulink>
</xsl:otherwise>
</xsl:choose>
</xsl:template>
<xsl:template match="i"><emphasis><xsl:apply-templates /></emphasis></xsl:template>
<xsl:template match="b"><emphasis role="bold"><xsl:apply-templates /></emphasis></xsl:template>
<xsl:template match="file"><filename><xsl:apply-templates /></filename></xsl:template>
<xsl:template match="sup"><superscript><xsl:apply-templates /></superscript></xsl:template>
<xsl:template match="img">
<xsl:choose>
<xsl:when test="@title">
<figure>
<xsl:attribute name="id"><xsl:value-of select="@id" /></xsl:attribute>
<xsl:if test="@float='true'"><xsl:attribute name="float-style">before</xsl:attribute></xsl:if>
<title><xsl:value-of select="@title"/></title>
<mediaobject><imageobject><imagedata align="center">
<xsl:attribute name="width"><xsl:choose>
<xsl:when test="@width"><xsl:value-of select="@width" /></xsl:when>
<xsl:otherwise>4.2in</xsl:otherwise>
</xsl:choose></xsl:attribute>
<xsl:attribute name="fileref">../images/<xsl:value-of select="@src"/></xsl:attribute>
</imagedata></imageobject>
</mediaobject></figure>
</xsl:when>
<xsl:otherwise>
<mediaobject><imageobject><imagedata align="center">
<xsl:attribute name="width"><xsl:choose>
<xsl:when test="@width"><xsl:value-of select="@width" /></xsl:when>
<xsl:otherwise>4.2in</xsl:otherwise>
</xsl:choose></xsl:attribute>
<xsl:attribute name="fileref">../images/<xsl:value-of select="@src"/></xsl:attribute>
</imagedata></imageobject>
</mediaobject>
</xsl:otherwise>
</xsl:choose>

</xsl:template>
<xsl:template match="todo"><remark>[TO DO:<xsl:apply-templates />]</remark></xsl:template>
<xsl:template match="quote"><blockquote>
	<xsl:choose>
	<xsl:when test="p or li"><xsl:apply-templates /></xsl:when>
	<xsl:otherwise>
		<para><xsl:apply-templates /></para>
	</xsl:otherwise>
	</xsl:choose>	
	</blockquote>
</xsl:template>
<xsl:template match="bib"><biblioref><xsl:attribute name="linkend"><xsl:value-of select="@ref" /></xsl:attribute></biblioref></xsl:template>
<xsl:template match="bibliography"><xi:include  xmlns:xi="http://www.w3.org/2001/XInclude"  href="../../plainbook/biblio.xml"/></xsl:template>
<xsl:template match="index">
<indexterm scope="global">
<primary><xsl:value-of select="@primary"/></primary>
<xsl:if test="@see"><see><xsl:value-of select="@see" /></see></xsl:if>
<xsl:if test="@secondary"><secondary><xsl:value-of select="@secondary" /></secondary></xsl:if></indexterm>
</xsl:template>
<xsl:template match="define">
<indexterm scope="global">
<primary><xsl:apply-templates /></primary>
</indexterm><xsl:apply-templates />
</xsl:template>
</xsl:stylesheet>
