#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    ui->papel->addItem("Estucado"); // INDEX 0
    ui->papel->addItem("Offset");   // INDEX 1

    ui->encuadernacion->addItem("Hilo");    // INDEX 0
    ui->encuadernacion->addItem("Fresado"); // INDEX 1
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_pushButton_clicked()
{
    short sheets;
    short grm;
    double vol;
    double final;
    short pags;

    QString tmpPags;
    QVariant tmpPaper;
    QVariant tmpSewing;
    QString tmpGrm;
    QVariant result;

    tmpPags = ui->npaginas->toPlainText();
    tmpPaper = ui->papel->currentIndex();
    tmpSewing = ui->encuadernacion->currentIndex();
    tmpGrm = ui->gramaje->toPlainText();

    if (tmpPaper == 0)
    {
        if (tmpSewing == 0)
            vol = 0.96;
        else
            vol = 0.95;
    }
    else
    {
        if (tmpSewing == 0)
            vol = 1.26;
        else
            vol = 1.25;
    }
    grm = tmpGrm.toInt();
    sheets = tmpPags.toInt() / 2;
    pags = tmpPags.toInt();
    result = (sheets * grm * vol) / 1000;
    final = result.toInt();

    if (pags % 4 != 0)
    {
        ui->resultado->setText("Las páginas deben ser multiplo de 4");
    }
    else
        ui->resultado->setText(QString::number(final) + "mm");
}
