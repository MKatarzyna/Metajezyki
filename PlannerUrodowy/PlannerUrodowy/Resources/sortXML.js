    var xslDoc;   // XSLT Document
    var xmlDoc;   // XML Document
    var xmlText;  // XSLT Text (for IE)
    var xslText;  // XML Text (for IE)
    var xmlHttpObj;
    var sortKey = "nazwa";
    var sortType = "text";
    var sortOrder = "ascending";

    function createXmlObject() {
        var xmlObj;
        if (window.ActiveXObject) {     
            try {
               xmlObj = new ActiveXObject("Microsoft.XMLHTTP");
            } catch (e) {
               xmlObj = new ActiveXObject("Msxml2.XMLHTTP");
            }        
        } else {        
            xmlObj = new XMLHttpRequest();
        }        
        return xmlObj;
    }

    function getStyleSheet() {
        xmlHttpObj = createXmlObject();    
        xmlHttpObj.open("GET", "uslugi.xslt", false);
        xmlHttpObj.send(null);
        if (xmlHttpObj.status === 200) {
            xslDoc = xmlHttpObj.responseXML; 
            xslText = xmlHttpObj.responseText;
        } else { 
            alert("error loading stylesheet " + xmlHttpObj.status);
        }    
    }

    function getDataFile() {
        xmlHttpObj = createXmlObject();    
        xmlHttpObj.open("GET", "uslugi.xslt", false);
        xmlHttpObj.send(null);
        if (xmlHttpObj.status === 200) {
            xmlDoc = xmlHttpObj.responseXML;
            xmlText = xmlHttpObj.responseText;
        } else {
            alert("error loading data file " + xmlHttpObj.status);
        }
    }

    function doTranslation() {
        var processor = new XSLTProcessor();
        processor.importStylesheet(xslDoc);
        processor.setParameter(null, "sortKey", sortKey);
        processor.setParameter(null, "sortOrder", sortOrder);
        processor.setParameter(null, "sortType", sortType);
        var newDocument = processor.transformToDocument(xmlDoc);
        document.getElementById("disp").innerHTML = new XMLSerializer().serializeToString(newDocument);        
    }

    function reSort(which) {
        if (sortKey == which) {
            sortOrder = (sortOrder == "ascending") ? "descending" : "ascending";
        } else {
            sortKey = which;        
            sortOrder = "ascending";
        }
        console.log(sortKey);
        sortType = (sortKey == "price" || sortKey == "year") ? "number" : "text";  
        doTranslation();
    }

    function init() {
        getStyleSheet();
        getDataFile();
        doTranslation();
    }

    init();