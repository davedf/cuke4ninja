<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:fo="http://www.w3.org/1999/XSL/Format"
                xmlns:mml="http://www.w3.org/1998/Math/MathML"
                version="1.0">
                
<xsl:import href="xsl/fo/docbook.xsl"/>
<xsl:param name="cover.picture">../images/cover-300dpi.png</xsl:param>
<xsl:param name="admon.graphics">1</xsl:param>
<xsl:param name="admon.graphics.path">../resources/xsl/images/</xsl:param>
<xsl:param name="admon.graphics.extension">.svg</xsl:param>
<xsl:param name="generate.toc" select="'book toc, title'"/>
<xsl:param name="xep.extensions" >1</xsl:param>
<xsl:param name="ulink.footnotes" >0</xsl:param>
<xsl:param name="use.extensions" >1</xsl:param>
<xsl:param name="graphicsize.extension">1</xsl:param>
<xsl:param name="page.height" >9in</xsl:param>
<xsl:param name="page.width" >6in</xsl:param>
<xsl:param name="page.margin.inner">0.75in</xsl:param>
<xsl:param name="page.margin.outer">0.75in</xsl:param>
<xsl:param name="double.sided">1</xsl:param>
<xsl:param name="body.start.indent">0.25in</xsl:param>
<xsl:param name="alignment">justify</xsl:param>
<xsl:param name="hyphenate">true</xsl:param>
<xsl:attribute-set name="book.titlepage.verso.style">
<xsl:attribute name="hyphenate">false</xsl:attribute>
</xsl:attribute-set>
<xsl:param name="body.font.master">10</xsl:param>
<xsl:param name="section.autolabel.max.depth">2</xsl:param>
<xsl:param name="insert.xref.page.number">0</xsl:param>
<xsl:param name="toc.max.depth">3</xsl:param>

<xsl:param name="title.fontset">AmericanTypewriter</xsl:param>
<xsl:param name="body.font.family">serif</xsl:param>
<xsl:param name="title.font.family">AmericanTypewriter</xsl:param>
<xsl:param name="bigtitle.font.family">AmericanTypewriter</xsl:param>
<xsl:param name="heading.font.family">AmericanTypewriter</xsl:param>
<xsl:param name="monospace.font.family">monospace</xsl:param>
<xsl:param name="code.font.family">monospace</xsl:param>
<xsl:param name="draft.mode">no</xsl:param>
<xsl:attribute-set name="section.title.level1.properties">
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 </xsl:attribute-set>
<xsl:attribute-set name="section.title.level2.properties">
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 </xsl:attribute-set>
<xsl:attribute-set name="section.title.level3.properties">
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 </xsl:attribute-set>
<xsl:attribute-set name="section.title.level4.properties">
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 </xsl:attribute-set>


<xsl:template match="processing-instruction('hard-pagebreak')">
   <fo:block break-after='page'/>
 </xsl:template>
 
<xsl:attribute-set name="chaplabel.title.properties">
<xsl:attribute name="font-family"><xsl:value-of select="$bigtitle.font.family" /></xsl:attribute>
  <xsl:attribute name="font-size">10pt</xsl:attribute>
  <xsl:attribute name="text-align">right</xsl:attribute>
 </xsl:attribute-set>


<xsl:attribute-set name="biblioentry.properties">
  <xsl:attribute name="start-indent">0.75in</xsl:attribute>
  <xsl:attribute name="text-align">start</xsl:attribute>
</xsl:attribute-set>

<xsl:attribute-set name="monospace.properties">
  <xsl:attribute name="font-size">9pt</xsl:attribute>
</xsl:attribute-set>

<xsl:attribute-set name="footnote.properties">
	<xsl:attribute name="text-align">start</xsl:attribute>
</xsl:attribute-set>

<xsl:attribute-set name="component.title.properties">
   <xsl:attribute name="font-size"><xsl:choose><xsl:when test="ancestor-or-self::bibliography">14pt</xsl:when><xsl:otherwise>30pt</xsl:otherwise></xsl:choose></xsl:attribute>
   <xsl:attribute name="font-family"><xsl:choose><xsl:when test="ancestor-or-self::bibliography"><xsl:value-of select="$heading.font.family" /></xsl:when><xsl:otherwise><xsl:value-of select="$bigtitle.font.family" /></xsl:otherwise></xsl:choose></xsl:attribute>
  <xsl:attribute name="border-bottom-width"><xsl:choose><xsl:when test="ancestor-or-self::bibliography">0mm</xsl:when><xsl:otherwise>1pt</xsl:otherwise></xsl:choose></xsl:attribute>
  <xsl:attribute name="border-bottom-style"><xsl:choose><xsl:when test="ancestor-or-self::bibliography">solid</xsl:when><xsl:otherwise>solid</xsl:otherwise></xsl:choose></xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 </xsl:attribute-set>
<xsl:attribute-set name="sidebar.title.properties"> 
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute> 
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="hyphenate">false</xsl:attribute>
</xsl:attribute-set>

   <xsl:attribute-set name="section.title.level1.properties">
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 </xsl:attribute-set>
<xsl:attribute-set name="section.title.level2.properties">
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="start-indent"><xsl:value-of select="$body.start.indent" /></xsl:attribute>
</xsl:attribute-set>
<xsl:attribute-set name="section.title.level3.properties">
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="start-indent"><xsl:value-of select="$body.start.indent" /></xsl:attribute>
</xsl:attribute-set>
<xsl:attribute-set name="section.title.level4.properties">
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="start-indent"><xsl:value-of select="$body.start.indent" /></xsl:attribute>
</xsl:attribute-set>
<xsl:attribute-set name="admonition.title.properties">
<xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="text-align">start</xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="font-style">italic</xsl:attribute>
 </xsl:attribute-set>
<xsl:attribute-set name="admonition.title.properties">
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-size">12pt</xsl:attribute>
  <xsl:attribute name="text-align">start</xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="font-style">italic</xsl:attribute>
 </xsl:attribute-set> 
<xsl:attribute-set name="admonition.properties">	
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-weight">normal</xsl:attribute>
  <xsl:attribute name="text-align">start</xsl:attribute>
</xsl:attribute-set>

<xsl:param name="bibliography.collection">biblio.xml</xsl:param>
<xsl:param name="bibliography.numbered">1</xsl:param> 
<xsl:attribute-set name="header.content.properties">
  <xsl:attribute name="font-family"><xsl:value-of select="$heading.font.family" /></xsl:attribute>
  <xsl:attribute name="font-size">9pt</xsl:attribute>
  <xsl:attribute name="text-align">start</xsl:attribute>
  <xsl:attribute name="wrap-option">no-wrap</xsl:attribute>
</xsl:attribute-set>

<xsl:template  match="sect1|sect2|sect3|sect4|sect5|section|sidebar|simplesect|tip|important"  
              mode="insert.title.markup">
 <xsl:param name="purpose"/>
 <xsl:param name="xrefstyle"/>
 <xsl:param name="title"/>
 <xsl:choose>
    <xsl:when test="$purpose = 'xref'"><fo:inline font-style="italic"><xsl:copy-of select="$title"/></fo:inline></xsl:when>
    <xsl:otherwise><xsl:copy-of select="$title"/></xsl:otherwise>
</xsl:choose></xsl:template>
<xsl:template  match="chapter|appendix"  
              mode="object.title.markup">
   <xsl:value-of select="title"/>
</xsl:template>
<!--
<xsl:template name="book.titlepage.before.recto"> 
<fo:block text-align="center" space-before.optimum="2in" space-before.minimum="2in"
space-after.optimum="1.5in" space-after.minimum="1in">
<fo:external-graphic src="url(../images/tre.png)" width="4.2in" height="auto" 
	content-width="scale-to-fit" content-height="scale-to-fit" text-align="center"/></fo:block>
</xsl:template>
-->
<xsl:attribute-set name="list.item.spacing">
  <xsl:attribute name="space-before.optimum">0.3em</xsl:attribute>
  <xsl:attribute name="space-before.minimum">0.2em</xsl:attribute>
  <xsl:attribute name="space-before.maximum">0.5em</xsl:attribute>
</xsl:attribute-set>

<xsl:template name="header.content">
  <xsl:param name="pageclass" select="''"/>
  <xsl:param name="sequence" select="''"/>
  <xsl:param name="position" select="''"/>
  <xsl:param name="gentext-key" select="''"/>
  <fo:block>

    <!-- sequence can be odd, even, first, blank -->
    <!-- position can be left, center, right -->
    <xsl:choose>
      <xsl:when test="$sequence = 'blank'">
        <!-- nothing -->
      </xsl:when>
      <xsl:when test="$sequence='odd' and $position='right' and $pageclass != 'titlepage'">
              <fo:retrieve-marker retrieve-class-name="section.head.marker"
                                  retrieve-position="first-including-carryover"
                                  retrieve-boundary="page-sequence"/>
      </xsl:when>
      <xsl:when test="$sequence='even' and $position='left' and $pageclass != 'titlepage'">
        <xsl:apply-templates select="." mode="titleabbrev.markup"/>
      </xsl:when>
      <xsl:when test="$sequence = 'first'">
        <!-- nothing for first pages -->
      </xsl:when>

    </xsl:choose>
  </fo:block>
</xsl:template>
<xsl:template name="head.sep.rule">
  <xsl:param name="pageclass"/>
  <xsl:param name="sequence"/>
  <xsl:param name="gentext-key"/>
  <xsl:if test="$header.rule != 0">
    <xsl:choose>
      <xsl:when test="$pageclass = 'titlepage'">
        <!-- off -->
      </xsl:when>
      <xsl:otherwise>
        <xsl:attribute name="border-bottom-width">0.5pt</xsl:attribute>
        <xsl:attribute name="border-bottom-style">solid</xsl:attribute>
        <xsl:attribute name="border-bottom-color">black</xsl:attribute>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:if>
</xsl:template>

<xsl:template name="foot.sep.rule">
  <xsl:param name="pageclass"/>
  <xsl:param name="sequence"/>
  <xsl:param name="gentext-key"/>
  <xsl:if test="$footer.rule != 0">
    <xsl:choose>
      <xsl:when test="$pageclass = 'titlepage'">
        <!-- off -->
      </xsl:when>
      <xsl:otherwise>
        <xsl:attribute name="border-top-width">0.5pt</xsl:attribute>
        <xsl:attribute name="border-top-style">solid</xsl:attribute>
        <xsl:attribute name="border-top-color">black</xsl:attribute>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:if>
</xsl:template>
<xsl:template match="mediaobject">
  <fo:block xsl:use-attribute-sets="normal.para.spacing"
        padding="3pt">
    <xsl:apply-templates/>
  </fo:block>
</xsl:template>

<xsl:attribute-set name="blockquote.properties">
 <xsl:attribute name="margin-left">0.3in</xsl:attribute>
 <xsl:attribute name="margin-right">0.2in</xsl:attribute>
  <xsl:attribute name="hyphenate">false</xsl:attribute>
 <xsl:attribute name="font-style">italic</xsl:attribute>
</xsl:attribute-set>
	<xsl:param name="local.l10n.xml" select="document('')" />
	<l:i18n xmlns:l="http://docbook.sourceforge.net/xmlns/l10n/1.0">
		<l:l10n language="en">
			<l:gentext key="hyphenation-push-character-count" text="3"/>
			<l:gentext key="hyphenation-remain-character-count" text="4"/>
			<l:context name="index">
				<l:template name="term-separator" text=" "/>
			</l:context>
			<l:context name="xref">
				<l:template name="appendix" text="Appendix %n" />
				<l:template name="chapter" text="Chapter %n" />
				<l:template name="figure" text="Figure %n" />
				<l:template name="section" style="code" text="%t on page %p" />
				<l:template name="section" text="the section %t on page %p" />
				<l:template name="simplesect" text="the section %t on page %p"/>
				<l:template name="table" text="table %n" />
				<l:template name="sidebar" text="the sidebar %t on page %p" />
				<l:template name="tip" text="tip %t on page %p" />
				<l:template name="important" text="tip %t on page %p" />
				<l:template name="part" text="Part %n"/>
				
			</l:context>
			<l:context name="xref-number">
				<l:template name="appendix" text="Appendix %n" />
				<l:template name="chapter" text="Chapter %n" />
				<l:template name="figure" text="Figure %n" />
				<l:template name="section" text="the section %t on page %p" />
				<l:template name="simplesect" text="the section %t on page %p"/>
				<l:template name="table" text="table %n" />
				<l:template name="sidebar" text="sidebar %t on page %p" />			
				<l:template name="tip" text="tip %t on page %p" />
				<l:template name="important" text="tip %t on page %p" />
				<l:template name="part" text="Part %n"/>
				
			</l:context>
			<l:context name="xref-number-and-title">
				<l:template name="appendix" text="Appendix %n" />
				<l:template name="chapter" text="Chapter %n" />
				<l:template name="figure" text="Figure %n" />
				<l:template name="section" text="the section %t on page %p" />
				<l:template name="simplesect" text="the section %t on page %p"/>
				<l:template name="table" text="table %n" />
				<l:template name="sidebar" text="sidebar %t on page %p" />
				<l:template name="tip" text="tip %t on page %p" />
				<l:template name="important" text="tip %t on page %p" />
				<l:template name="part" text="Part %n"/>
				
			</l:context>
		</l:l10n>
	</l:i18n>
<xsl:template  match="chapter"  
              mode="object.title.markup">
  <fo:block xsl:use-attribute-sets="chaplabel.title.properties" keep-with-next="always">              
Chapter <xsl:apply-templates select="." mode="label.markup"/>&#x000A0;
  </fo:block>
   <xsl:value-of select="title"/>
</xsl:template>
<xsl:template  match="appendix"  
              mode="object.title.markup">
  <fo:block xsl:use-attribute-sets="chaplabel.title.properties" keep-with-next="always">              
Appendix <xsl:apply-templates select="." mode="label.markup"/>.
  </fo:block>
   <xsl:value-of select="title"/>
</xsl:template>


<!--  the following two templates set the cover page -->
<xsl:template name="user.pagemasters">
    <fo:simple-page-master margin-bottom="0in" margin-top="0in" page-height="9in" 
    	page-width="6in" master-name="no-margins" margin-left="0in" margin-right="0in">
      <fo:region-body margin-top="0in" margin-bottom="0in" display-align="center"/>
    </fo:simple-page-master>

   <fo:page-sequence-master master-name="cover">
      <fo:repeatable-page-master-alternatives>
        <fo:conditional-page-master-reference blank-or-not-blank="blank" master-reference="no-margins"/>
        <fo:conditional-page-master-reference page-position="first" master-reference="no-margins"/>
        <fo:conditional-page-master-reference odd-or-even="odd" master-reference="no-margins"/>
        <fo:conditional-page-master-reference odd-or-even="even" master-reference="no-margins"/>
      </fo:repeatable-page-master-alternatives>
    </fo:page-sequence-master>


</xsl:template>

<xsl:template name="front.cover">
  <fo:page-sequence xmlns:mml="http://www.w3.org/1998/Math/MathML" 
  xmlns:axf="http://www.antennahouse.com/names/XSL/Extensions" 
  	hyphenation-remain-character-count="4" hyphenation-push-character-count="3" 
  	hyphenation-character="-" force-page-count="end-on-even" 
  	initial-page-number="1" format="1" language="en" 
  	hyphenate="true" master-reference="cover">
    <fo:flow flow-name="xsl-region-body">
	<fo:block text-align="center">
      <fo:external-graphic text-align="center" content-height="scale-to-fit" 
      	content-width="scale-to-fit" width="5.9in" >
      	<xsl:attribute name="src">url(<xsl:value-of select="$cover.picture" />)</xsl:attribute>
      	</fo:external-graphic>
	</fo:block>
    </fo:flow>
  </fo:page-sequence>
</xsl:template>


</xsl:stylesheet>
