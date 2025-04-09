document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.cell-content').forEach(function (cell) {
        cell.addEventListener('click', function () {
            this.classList.toggle('expanded');
        });
    });
});
