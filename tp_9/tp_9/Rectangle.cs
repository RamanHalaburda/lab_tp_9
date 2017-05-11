using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_9
{
    /*
        Определить понятие «Точка». Состояние объекта определяется
        следующими полями:
        координата по оси абсцисс (вещественное число);
        координата по оси ординат (вещественное число).
        Базируясь на понятии «Точка», определить понятие
        «Прямоугольник». Прямоугольник определить через точки,
        соответствующие его левому верхнему и правому нижнему
        углам. Сдвинуть правый нижний угол прямоугольника пообеим
        осям на заданное расстояние DELTA и вычислить периметр
        прямоугольника после сдвига угла.
    */
    class Rectangle
    {
        private Point leftBottom;
        private Point rightTop;

        public Rectangle(Point _p1, Point _p2)
        {
            this.setLeftBottom(_p1);
            this.setRightTop(_p2);
        }

        private void setLeftBottom(Point _p1)
        {
            this.leftBottom = new Point(_p1);
        }

        private void setRightTop(Point _p2)
        {
            this.rightTop = new Point(_p2);
        }

        public void moveRectangle(double _step)
        {
            this.leftBottom.setX(this.leftBottom.getX() + _step);
            this.leftBottom.setY(this.leftBottom.getY() + _step);
            this.rightTop.setX(this.rightTop.getX() + _step);
            this.rightTop.setY(this.rightTop.getY() + _step);
        }

        public override string ToString()
        {
            return String.Concat(
                "((", this.leftBottom.getX().ToString(),
                ",", this.leftBottom.getY().ToString(),
                "),(", this.rightTop.getX().ToString(),
                ",", this.rightTop.getY().ToString(),"))");
        }
    }
}
