function setTextProperty(ppName, ppValue)
global textfontsize;
global textfontname;
global textfontweight;
global textfontangle;
switch lower(ppName)
    case 'fontname'
        textfontname = ppValue;
    case 'fontsize'
        textfontsize = ppValue;
    case 'fontweight'
        textfontweight = ppValue;
    case 'fontangle'
        textfontangle = ppValue;
end
textHandles = findobj(gcf, 'type', 'text');
set(textHandles, ppName, ppValue);
end