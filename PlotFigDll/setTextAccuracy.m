function setTextAccuracy(t)
global textaccuracy;
textaccuracy = t;
textHandles = findobj(gcf, 'type', 'text');
for i = 1:length(textHandles)
    v = get(textHandles(i), 'UserData');
    set(textHandles(i), 'String', sprintf(['%' sprintf('.%d', t) 'f'], v));
end
end
