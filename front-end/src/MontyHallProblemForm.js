import axios from "axios";
import React, { useState } from "react";
import { Button, Grid, TextField, Switch, Typography } from "@mui/material";

const URL = "http://localhost:5000/api/montyhallproblem";

const ResultRow = ({ title, value }) => {
  return (
    <div
      style={{
        display: "flex",
        flex: 1,
        flexDirection: "row",
        alignItems: "center",
        justifyContent: "flex-start",
        gap: 4,
        borderRadius: 8,
        border: "2px solid #0096FF",
        margin: 8,
      }}
    >
      <Typography margin={2} flex={0.8} textAlign={"left"}>
        {title}
      </Typography>
      <Typography margin={2} alignItems={"flex-end"} textAlign={"right"}>
        {value}
      </Typography>
    </div>
  );
};

const MontyHallProblem = (props) => {
  const [numberOfSimulations, setNumberOfSimulations] = useState(1);
  const [changeSelectedDoor, setChangeSelectedDoor] = useState(false);
  const [simulationResult, setSimulationResult] = useState(null);
  const [error, showError] = useState(false);

  const onChangeSimulations = (event) => {
    setNumberOfSimulations(event.target.value);
  };

  const onChangeDoor = () => {
    setChangeSelectedDoor((prev) => !prev);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    axios
      .post(URL, {
        numberOfSimulations: numberOfSimulations,
        changeSelectedDoor: changeSelectedDoor,
      })
      .then((result) => {
        setSimulationResult(result?.data || null);
        if (error) {
          showError(false);
        }
      })
      .catch((error) => {
        setSimulationResult(null);
        showError(true);
      });
  };

  return (
    <>
      <Grid
        margin="normal"
        color="primary"
        variant="filled"
        display={"flex"}
        flexDirection={"column"}
        justifyContent={"flex-start"}
        gap={4}
      >
        <h1> Monty Hall Problem</h1>

        <TextField
          type="number"
          helperText="Number of games to simulate"
          name={"numberOfSimulations"}
          onChange={onChangeSimulations}
          label="Number of Games"
          InputProps={{
            inputProps: {
              min: 1,
            },
          }}
          value={numberOfSimulations}
        />

        <div
          style={{
            display: "flex",
            flexDirection: "row",
            justifyContent: "flex-start",
            alignItems: "center",
          }}
        >
          <Typography>Change the door</Typography>
          <Switch
            color="primary"
            size="medium"
            name={"changeSelectedDoor"}
            checked={changeSelectedDoor}
            onChange={onChangeDoor}
          />
        </div>

        <Button variant="contained" onClick={handleSubmit}>
          Find My Winning Chances
        </Button>
      </Grid>
      {error && (
        <Typography margin={2} fontWeight={"bold"} color={"red"}>
          {"Something went wrong. Please try again later !!"}
        </Typography>
      )}
      {simulationResult && (
        <>
          <Typography margin={2} fontWeight={"bold"}>
            {"Your Results"}
          </Typography>

          <ResultRow
            title="Number of Simulations"
            value={simulationResult?.numerOfSimulations || 0}
          />

          <ResultRow
            title="Number of Wins"
            value={simulationResult?.numberOfWins || 0}
          />
          <ResultRow
            title="Number of Losses"
            value={simulationResult?.numberOfLoses || 0}
          />
          <ResultRow
            title="Win Ratio"
            value={`${simulationResult?.winRatio?.toFixed(2) || 0}%`}
          />
        </>
      )}
    </>
  );
};

export default MontyHallProblem;
