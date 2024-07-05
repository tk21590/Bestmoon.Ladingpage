// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// initialize scrollspy
$('body').scrollspy({

    target: '.dotted-scrollspy'
});

// initialize lightbox
$(function () {

    $("#mdb-lightbox-ui ").load("mdb-addons/mdb-lightbox-ui.html ");
});

/* WOW.js init */
new WOW().init();

$('.navbar-collapse a').click(function () {
    $(".navbar-collapse ").collapse('hide');
});


document.addEventListener("DOMContentLoaded", function () {
    const text = document.getElementById('chatText');
    const words = ["Dịch vụ", "Giải pháp", "Công nghệ"];
    let wordIndex = 0;
    let charIndex = 0;

    function typeLetter() {
        if (charIndex < words[wordIndex].length) {
            text.innerHTML = words[wordIndex].substring(0, charIndex + 1);
            charIndex++;
            setTimeout(typeLetter, 150); // Tốc độ gõ chữ
        } else {
            charIndex = 0;
            wordIndex++;
            if (wordIndex < words.length) {
                setTimeout(typeLetter, 900); // Thời gian chờ giữa các từ
            } else {
                wordIndex = 0;
                charIndex = 0;
                setTimeout(() => {
                    text.innerHTML = ''; // Xóa văn bản hiện tại để gõ lại
                    typeLetter();
                }, 2000); // Thời gian chờ sau khi hoàn thành trước khi lặp lại
            }
        }
    }

    typeLetter();
});

function shrinkElements(selector) {
    var elements = document.querySelectorAll(selector);
    elements.forEach(function (element) {
        var anchor = element.querySelector('a');
        anchor.classList.remove('btn-lg');
        anchor.classList.add('btn-sm');
        anchor.classList.remove('p-4');
    });
}

function expandElements(selector) {
    var elements = document.querySelectorAll(selector);
    elements.forEach(function (element) {
        var anchor = element.querySelector('a');
        anchor.classList.remove('btn-sm');
        anchor.classList.add('btn-lg');
        anchor.classList.add('p-4');
    });
}

function toggleAnimations() {
    shrinkElements('.fadeAll');
    expandElements('.fadeDown');
    setTimeout(function () {
        expandElements('.fadeAll');
        shrinkElements('.fadeDown');
        setTimeout(toggleAnimations, 5000); // Lặp lại sau 3 giây
    }, 5000);
}

toggleAnimations();


function typeWriterEffect(text, element, speed) {
    let i = 0;
    const typingInterval = setInterval(() => {
        if (i < text.length) {
            element.innerHTML += text.charAt(i);
            i++;
        } else {
            clearInterval(typingInterval);
            setTimeout(() => {
                backspaceEffect(text, element, speed); // Start backspace effect
            }, 2000); // Wait for 2 seconds before starting backspace effect
        }
    }, speed);
}

function backspaceEffect(text, element, speed) {
    let i = text.length - 1;
    const backspaceInterval = setInterval(() => {
        if (i >= 0) {
            element.innerHTML = text.substring(0, i);
            i--;
        } else {
            clearInterval(backspaceInterval);
            setTimeout(() => {
                typeWriterEffect(text, element, speed); // Restart typing effect
            }, 2000); // Wait for 2 seconds before starting typing effect
        }
    }, speed);
}

const heading = document.getElementById('typingEffect');
const text = heading.innerText;
heading.innerText = ''; // Clear initial text
typeWriterEffect(text, heading, 50);