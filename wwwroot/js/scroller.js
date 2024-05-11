function scrollToBottom(elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        element.scrollTop = element.scrollHeight;
    }
}

function isScrolledToBottom(elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        return (element.scrollHeight - element.scrollTop === element.clientHeight);
    }
    return false;
}