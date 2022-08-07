/// <reference path="JQuery.d.ts" />
var PointList = /** @class */ (function () {
    function PointList() {
        this.points = new Array();
    }
    PointList.prototype.load = function () {
        var _this = this;
        $.getJSON('https://localhost:44312/Main/GetAllPoints', function (data) {
            _this.points = data.value;
            console.log(_this.points);
        });
        //var stage: Stage = new Stage({ container: 'convaHolder', width: 1000, height: 1000 });
        //var layer: Layer = new Layer();
        //$.each(this.points, (index, value) => {
        //    var circle: Circle;
        //    circle.setAttr('id', value.Id);
        //    circle.setAttr('x', value.PositionX);
        //    circle.setAttr('y', value.PositionY);
        //    circle.setAttr('radius', value.Radius);
        //    circle.setAttr('fill', value.Color);
        //    layer.add(circle);
        //    circle.on('dblclick', () => {
        //        $.ajax({
        //            url: 'https://localhost:44312/Main/RemovePoint?id=' + value.Id,
        //            type: 'DELETE',
        //            success: function (result) {
        //                location.reload();
        //            }
        //        });
        //    })
        //    var comments: PointsComment[] = value.Comments;
        //    var count: number = 0;
        //    $.each(comments, (indexForComment, valueUnderTheCommentIndex) => {
        //        var label: Label;
        //        label.setAttr('x', value.PositionX);
        //        label.setAttr('y', value.PositionY + circle.getAttr('radius') + 10 + count * 40);
        //        //var tag: Konva.Tag;
        //        //tag.setAttr('fill', valueUnderTheCommentIndex.Color);
        //        //tag.setAttr('stroke','black');
        //        //tag.setAttr('shadowColor', 'black');
        //        //tag.setAttr('shadowBlur', 10);
        //        //tag.setAttr('shadowOffset', [10, 10]);
        //        //tag.setAttr('shadowOpacity', 0.2);
        //        //tag.setAttr('lineJoin', 'round');
        //        //tag.setAttr('cornerRadius', 5);
        //        //label.add(tag);
        //        var text: Text;
        //        text.setAttr('text', valueUnderTheCommentIndex.Text);
        //        text.setAttr('fontSize', 11);
        //        text.setAttr('lineHeight', 1.2);
        //        text.setAttr('padding', 10);
        //        text.setAttr('fill', 'green');
        //        label.add(text);
        //        label.setAttr('setOffsetX', label.getAttr('width') / 2);
        //        count = count + 1;
        //        layer.add(label);
        //    })
        //})
        //stage.add(layer);
    };
    return PointList;
}());
var Point = /** @class */ (function () {
    function Point() {
    }
    return Point;
}());
var PointsComment = /** @class */ (function () {
    function PointsComment() {
    }
    return PointsComment;
}());
window.onload = function () {
    var points = new PointList();
    points.load();
};
