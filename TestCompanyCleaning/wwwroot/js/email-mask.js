//{
//  "exclude": [
//    "**/bin",
//    "**/bower_components",
//    "**/jspm_packages",
//    "**/node_modules",
//    "**/obj",
//    "**/platforms"
//  ]
//}

document.addEventListener("DOMContentLoaded", function () {
    document.querySelectorAll("input[type='email'], input[placeholder*='@']").forEach(input => {
        input.addEventListener("input", function (e) {
            const value = this.value;
            // Разрешённые символы: латиница, цифры, -, _, @ и .
            const validValue = value.replace(/[^a-zA-Z0-9@._-]/g, '');
            if (value !== validValue) {
                this.value = validValue;
            }
        });
    });
});