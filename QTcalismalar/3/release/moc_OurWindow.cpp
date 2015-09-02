/****************************************************************************
** Meta object code from reading C++ file 'OurWindow.h'
**
** Created: Tue 30. Oct 18:40:28 2012
**      by: The Qt Meta Object Compiler version 63 (Qt 4.8.3)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../include/OurWindow.h"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'OurWindow.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 63
#error "This file was generated using the moc from 4.8.3. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_OurWindow[] = {

 // content:
       6,       // revision
       0,       // classname
       0,    0, // classinfo
       7,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       0,       // signalCount

 // slots: signature, parameters, type, tag, flags
      11,   10,   10,   10, 0x08,
      23,   10,   10,   10, 0x08,
      40,   10,   10,   10, 0x08,
      57,   10,   10,   10, 0x08,
      73,   10,   10,   10, 0x08,
      89,   10,   10,   10, 0x08,
     105,   10,   10,   10, 0x08,

       0        // eod
};

static const char qt_meta_stringdata_OurWindow[] = {
    "OurWindow\0\0clickUndo()\0clickBlackRedo()\0"
    "clickGreenRedo()\0clickBlueRedo()\0"
    "clickRdbBlack()\0clickRdbGreen()\0"
    "clickRdbBlue()\0"
};

void OurWindow::qt_static_metacall(QObject *_o, QMetaObject::Call _c, int _id, void **_a)
{
    if (_c == QMetaObject::InvokeMetaMethod) {
        Q_ASSERT(staticMetaObject.cast(_o));
        OurWindow *_t = static_cast<OurWindow *>(_o);
        switch (_id) {
        case 0: _t->clickUndo(); break;
        case 1: _t->clickBlackRedo(); break;
        case 2: _t->clickGreenRedo(); break;
        case 3: _t->clickBlueRedo(); break;
        case 4: _t->clickRdbBlack(); break;
        case 5: _t->clickRdbGreen(); break;
        case 6: _t->clickRdbBlue(); break;
        default: ;
        }
    }
    Q_UNUSED(_a);
}

const QMetaObjectExtraData OurWindow::staticMetaObjectExtraData = {
    0,  qt_static_metacall 
};

const QMetaObject OurWindow::staticMetaObject = {
    { &QMainWindow::staticMetaObject, qt_meta_stringdata_OurWindow,
      qt_meta_data_OurWindow, &staticMetaObjectExtraData }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &OurWindow::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *OurWindow::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *OurWindow::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_OurWindow))
        return static_cast<void*>(const_cast< OurWindow*>(this));
    return QMainWindow::qt_metacast(_clname);
}

int OurWindow::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QMainWindow::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        if (_id < 7)
            qt_static_metacall(this, _c, _id, _a);
        _id -= 7;
    }
    return _id;
}
QT_END_MOC_NAMESPACE
