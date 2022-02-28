// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const box = document.getElementById('box');

const btn = document.getElementById('btn');//drowdown

btn.addEventListener('click', function handleClick() {
    if (box.style.display === 'none') {
        box.style.display = 'block';

        btn.textContent = 'Show div';
    } else {
        box.style.display = 'none';

        btn.textContent = 'Hide div';
    }
});