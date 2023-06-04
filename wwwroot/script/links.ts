function SetOpenLinksNewTab(): void
{
    const links: NodeListOf<HTMLAnchorElement> = document.querySelectorAll('.info a');

    links.forEach(link => { link.setAttribute('target', '_blank'); });
}

SetOpenLinksNewTab();