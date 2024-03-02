// создание строки для таблицы
function makeRow(record, recordName) {

    const tr = document.createElement("tr");
    tr.setAttribute("row-name", recordName);

    const dateTd = document.createElement("td");
    dateTd.append(recordName);
    tr.append(dateTd);

    for (var i in record) {

        const propertyTd = document.createElement("td");
        tr.setAttribute("property", i);

        propertyTd.append(record[i]);
        tr.append(propertyTd);
    }
    return tr;
}
//создание таблицы из лога
function createTable(log) {

    const body = document.querySelector("body");
    const table = document.createElement("table");
    const rows = document.createElement("tbody");
    const thead = document.createElement("thead");
    const rowHead = document.createElement("tr");

    thead.append(rowHead);
    table.append(thead);
    table.append(rows);
    body.append(table);

    // создаем шапку таблицы
    for (var record in log.records) {

        const cell = document.createElement("th");
        cell.append("date");
        rowHead.append(cell);
        for (var i in log.records[record]) {
            const cell = document.createElement("th");
            cell.append(i);
            rowHead.append(cell);
        }
        break;
    }
    // добавляем полученные элементы в таблицу
    for (var record in log.records) {
        rows.append(makeRow(log.records[record], record));
    }
}