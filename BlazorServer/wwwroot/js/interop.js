function createAlert() {
    alert("Hey this an alert");
}

function createPrompt(question) {
    return prompt(question);
}
function setElementTextById(id, text){
    document.getElementById(id).innerText = text;
}

function focusOnElement(element) {
    element.focus();
}
function giveMeRandomInt(maxIntSize, dotnetInstance) {
    dotnetInstance.invokeMethodAsync('GenerateRandomInt', maxIntSize)
        .then(result => {
            setElementTextById('randomNumberSpan', result);
        });

    //DotNet.invokeMethodAsync('BlazorServer', 'GenerateRandomInt', maxIntSize)
    //    .then(result => {
    //        setElementTextById('randomNumberSpan', result);
    //    });
}