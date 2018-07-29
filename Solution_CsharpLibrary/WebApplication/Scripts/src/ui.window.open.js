// removes the opener information to prevent opened page having JavaScript access to the opener
function openWindow(url) {
	var newWindow = window.open(url);
	newWindow.opener = null;
}