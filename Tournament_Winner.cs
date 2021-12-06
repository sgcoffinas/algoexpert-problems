using System.Collections.Generic;
using System;

public class Program 
{
	public string TournamentWinner(List<List<string> > competitions, List<int> results) 
	{
		var scoreboard = new Dictionary<string, int>();
		
		for (int i = 0; i < results.Count; i++) 
		{
			if (results[i] == 1) 
			{
				if (scoreboard.ContainsKey(competitions[i][0])) 
				{
					scoreboard[competitions[i][0]] += 3;
				} else 
				{
					scoreboard[competitions[i][0]] = 3;
				}
			} else 
			{
				if (scoreboard.ContainsKey(competitions[i][1])) 
				{
					scoreboard[competitions[i][1]] += 3;
				} else 
				{
					scoreboard[competitions[i][1]] = 3;
				}
			}
		}
		
		var winner = "";
		var mostPoints = 0;
		foreach (var key in scoreboard.Keys) 
		{
			if (scoreboard[key] > mostPoints) 
			{
				winner = key;
				mostPoints = scoreboard[key];
			}
		}
		
		return winner;
	}
}