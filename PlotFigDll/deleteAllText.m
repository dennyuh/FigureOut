function deleteAllText()
textHandles = findobj(gcf, 'type', 'text');
delete(textHandles);
end