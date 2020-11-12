(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        var data = {
            name: document.getElementById('Name').value,
            description: document.getElementById('Description').value,
            isVisible: document.getElementById('IsVisible').checked
        };

        const response = await fetch('/api/Exchanges', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data)
        });
        const responseJson = await response.json();

        if (responseJson.success) {
            document.getElementById("success-alert").removeAttribute("style");
        }
    };

    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();