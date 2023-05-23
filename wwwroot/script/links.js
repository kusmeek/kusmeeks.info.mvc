function SetOpenLinksNewTab() {
    var links = document.querySelectorAll('.info a');
    links.forEach(function (link) { link.setAttribute('target', '_blank'); });
}
SetOpenLinksNewTab();
//# sourceMappingURL=links.js.map