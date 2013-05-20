function createFigHandle()
h_fig = figure('Visible','off');
set(h_fig, 'MenuBar', 'none');
set(h_fig, 'Color', 'w');
set(h_fig, 'NumberTitle', 'off');
set(h_fig, 'CloseRequestFcn', {@FigureCloseCallback});
set(h_fig, 'WindowButtonMotionFcn', {@FigureMouseMoveCallback});
global uicontextmenupeak;
uicontextmenupeak = createContextMenuPeak();
global uicontextmenutext;
uicontextmenutext= createContextMenuText();
global uicontextmunugeneral;
uicontextmunugeneral= createContextMenuGeneral();
global textfontsize;
textfontsize = 10;
global textfontname;
textfontname = 'Arial';
global textaccuracy;
textaccuracy = 2;
global textfontweight;
textfontweight = 'normal';
global textfontangle;
textfontangle = 'normal';
warning('off','MATLAB:HandleGraphics:ObsoletedProperty:JavaFrame');
jframe=get(h_fig,'javaframe');
jIcon=javax.swing.ImageIcon;
jframe.setFigureIcon(jIcon);
set(gca, 'Box', 'off');
set(gca, 'TickDir', 'out');
set(gca, 'XMinorTick', 'on');
set(gca, 'YMinorTick', 'on');
hold on;
end

function FigureCloseCallback(src, evnt)
set(gcf, 'Visible', 'off');
end

function h = createContextMenuPeak()
h = uicontextmenu;
uimenu(h, 'Label', 'Annotate', 'Callback', {@AnnotatePeakCallback});
end

function AnnotatePeakCallback(src, evnt)
x = get(gco, 'XData');
y = get(gco, 'YData');
global textaccuracy;
global textfontsize;
global textfontname;
global textfontweight;
global textfontangle;
global uicontextmenutext;
textHandle = text(x,y,sprintf(['%' sprintf('.%d', textaccuracy) 'f'], x));
set(textHandle, 'HorizontalAlignment', 'center', 'VerticalAlignment', 'bottom', 'FontSize', textfontsize,...
        'FontName', textfontname, 'uicontextmenu', uicontextmenutext, 'FontWeight', textfontweight,...
        'FontAngle', textfontangle, 'UserData', x);
end

function h = createContextMenuText()
h = uicontextmenu;
uimenu(h, 'Label', 'Delete', 'Callback', {@DeleteAnnotationCallback});
end

function DeleteAnnotationCallback(src, evnt)
delete(gco);
end

function h = createContextMenuGeneral()
h = uicontextmenu;
end

function FigureMouseMoveCallback(src, evnt)
t = 0.005;
range = get(gca, 'XLim');
r = abs(range(2)-range(1))*t;
pt = get(gca,'CurrentPoint');
allPeaks = findobj(gca, 'Type', 'line');
set(allPeaks(1:end-1), 'Visible', 'off');
allText = findobj(gca, 'Type', 'Text');
set(allText, 'Selected', 'off');
for i = 1:length(allText)
    rect = get(allText(i), 'Extent');
    if inpolygon(pt(1,1),pt(1,2),[rect(1) rect(1)+rect(3) rect(1)+rect(3) rect(1) rect(1)],[rect(2) rect(2) rect(2)+rect(4) rect(2)+rect(4) rect(2)])
        set(allText(i), 'Selected', 'on');
        return;
    end
end
for i = 1:length(allPeaks)-1
    px = get(allPeaks(i), 'XData');
    py = get(allPeaks(i), 'YData');
    if inpolygon(pt(1,1),pt(1,2),[px-r px+r px+r px-r px-r],[py-r py-r py+r py+r py-r])
        set(allPeaks(i), 'Visible', 'on');
        set(allPeaks(i), 'Selected', 'on');
        return;
    end
end
end