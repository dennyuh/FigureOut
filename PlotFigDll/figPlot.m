function figPlot(x,y,threshold,fsize,fname,t)
global textfontsize;
global textfontname;
global textaccuracy;
textfontsize = fsize;
textfontname = fname;
textfontaccuracy = t;
h=plot(x,y,'k');
set(h, 'HitTest', 'off');
[pks,locs]=findpeaks(y,'minpeakheight',0);
global uicontextmenupeak;
for i = 1:length(pks)
    h = plot(x(locs(i)), pks(i), 'r.', 'MarkerSize', 20);
    set(h, 'Visible', 'off', 'uicontextmenu', uicontextmenupeak);
end
[pks,locs]=findpeaks(y,'minpeakheight',threshold);
createText(x(locs),pks,x(locs),fsize,fname,t);
end