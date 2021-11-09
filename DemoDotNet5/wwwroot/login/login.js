const signIn = document.querySelector("#signInButton");
const signUp = document.querySelector("#signUpButton");
const signInForm = document.querySelector(".container .sign-in-form");
const signUpForm = document.querySelector(".container .sign-up-form");
const overlay_container = document.querySelector(
    ".container .overlay-container"
);
const overlay = document.querySelector(
    ".container .overlay-container .overlay"
);

signIn.addEventListener("click", () => {
    overlay_container.style.transform = "translateX(100%)";
    overlay.style.transform = "translateX(-50%)";
    signInForm.classList.add("active");
    signUpForm.classList.remove("active");
});
signUp.addEventListener("click", () => {
    overlay_container.style.transform = "translateX(0)";
    overlay.style.transform = "translateX(0)";
    signUpForm.classList.add("active");
    signInForm.classList.remove("active");
});

// *********************
// This Code is for only the floating card in right bottom corner
// **********************

const WebCifarIcon = document.querySelector("#webCifar-icon");
const WebCifarEl = document.querySelector("#webCifar");
const close = WebCifarEl.querySelector(".close");
const youtubeLink = document.querySelector(".youtubeLink");

WebCifarIcon.addEventListener("click", () => {
    WebCifarEl.classList.add("active");
});
close.addEventListener("click", () => {
    WebCifarEl.classList.remove("active");
});

youtubeLink.setAttribute("href", "https://youtu.be/7FbpuWOffc0");
/*Chèn Fontawesome dô nghen:  https://kit.fontawesome.com/a076d05399.js*/

const pass_field = document.querySelector('.pass-key');
const showBtn = document.querySelector('.show');
showBtn.addEventListener('click', function () {
    if (pass_field.type === "password") {
        pass_field.type = "text";
        showBtn.textContent = "HIDE";
        showBtn.style.color = "#3498db";
    } else {
        pass_field.type = "password";
        showBtn.textContent = "SHOW";
        showBtn.style.color = "#222";
    }
});
