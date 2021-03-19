#include "mainwindow.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    system("mkdir -p ~/Qt/6.0.2");
    system("cp ./srcs/plugins ~/Qt/6.0.2/");
    QApplication a(argc, argv);
    MainWindow w;
    w.show();
    return a.exec();
}
