using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Utility;

namespace TextAdventure {
  public class Room {
    public List<string> file;
    public string[] layout;
    public string[] defaultLayout;
    public string alias;
    public int startLayout, endLayout, startClues, endClues;
    public Coord[] clueCoords;
    public string[] clues;
    public string currentClue = "";

    public Room(string placeName, string roomName) {

      alias = roomName;
      file = Utility.FileHelper.loadRoom(placeName, roomName);

      startLayout = file.IndexOf("Layout");
      endLayout = file.IndexOf("End Layout");

      startClues = file.IndexOf("Clues");
      endClues = file.IndexOf("End Clues");

      readClues(startClues, endClues);

      if (layout == null) {
        layout = readLayout(startLayout, endLayout);
      }
      defaultLayout = layout;
     
    }

    public void Search() {

      Coord search;
      Boolean isClue, searching = true;
      string searchString;

      while (searching) {

        search = getValidCoord();
        isClue = false;

        if (search.coordY >= 0 && search.coordX >= 0) {
          searchString = layout[search.coordY].Substring(search.coordX, 1);
        }
        else {
          searching = false;
          break;
        }

          
        for (int i = 0; i < clueCoords.Length; i++) {

          if (search.coordX == clueCoords[i].coordX && search.coordY == clueCoords[i].coordY) {
            currentClue = clues[i];
            isClue = true;
          }

        }

        if (searchString != "#") {

          if (isClue) {
            layout[search.coordY] = layout[search.coordY].Substring(0, search.coordX) + "?" + layout[search.coordY].Substring(search.coordX + 1);
           
          }
          else {
            layout[search.coordY] = layout[search.coordY].Substring(0, search.coordX) + "-" + layout[search.coordY].Substring(search.coordX + 1);
          }
        }

      }

    }

    private void readClues(int start, int end) {

      string[] layout, temp;
      int fileStart = start + 1, length = (end - start) - 1;

      clueCoords = new Coord[length];
      clues = new string[length];
      layout = new string[length];

      for (int i = 0; i < length; i++) {

        layout[i] = file[i + (fileStart)];
        temp = layout[i].Split(',');

        clueCoords[i] = new Coord(int.Parse(temp[0]), int.Parse(temp[1]));

        clues[i] = temp[2];
       
      }


    }

    private Coord getValidCoord() {

      Regex regex = new Regex("^\\d{1,2},\\d{1,2}$");
      Coord search = new Coord(0, 0);
      string input;
      Boolean isValid = false;

      while (!isValid) {

        Utility.GraphicsHelper.ReDraw();
        Utility.GraphicsHelper.drawRoomLayout(layout);       

        Console.SetCursorPosition(3, 13);
        Console.Write("Coords: ");
        input = Console.ReadLine();

        if (regex.IsMatch(input)) {
          string[] coords = input.Split(',');
          search = new Coord(int.Parse(coords[0]), int.Parse(coords[1]));

          if ((search.coordY < layout.Length && search.coordY >= 0) && (search.coordX < file[search.coordY].Length && search.coordX >= 0)) {

            isValid = true;
            Console.WriteLine(input);

          }

        }
        else if (input.Equals("leave")) {
          isValid = true;
          search = new Coord(-1, -1);
        }

      }


      return search;

    }

    private string[] readLayout(int start, int end) {

      string[] layout;
      int fileStart = start + 1;

      layout = new string[end - 1];

      for (int i = 0; i < end - 1; i++) {

        layout[i] = file[i + (fileStart)];

      }

      return layout;


    }
  }
}

