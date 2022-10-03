import axios from "axios";
import React, { useState } from "react";

const MontyHallProblem = (props) => {
  const INITIAL_STATE = {
    numberOfSimulations: "",
    changeSelectedDoor: "false",
  };

  const [form, setForm] = useState(INITIAL_STATE);
  const [simulationResult, setSimulationResult] = useState({});

  const handleChange = (event) => {
    setForm({
      ...form,
      [event.target.name]: event.target.value,
    });
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    axios
      .post("http://localhost:5000/api/montyhallproblem", {
        ...form,
        changeSelectedDoor: form.changeSelectedDoor === "true",
      })
      .then((result) => {
        setSimulationResult(result.data);
        console.log(result);
      })
      .catch((error) => {
        console.log(error);
      });
    setForm(INITIAL_STATE);
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Number of Games to simulate :</label>
          <input
            type="text"
            name="numberOfSimulations"
            onChange={handleChange}
            value={form.numberOfSimulations}
          />
        </div>
        <div>
          <input
            type="radio"
            id="dontChange"
            name="changeSelectedDoor"
            value="false"
            checked={form.changeSelectedDoor === "false"}
            onChange={handleChange}
          />
            <label>Dont Change</label>
          <input
            type="radio"
            id="change"
            name="changeSelectedDoor"
            value="true"
            checked={form.changeSelectedDoor === "true"}
            onChange={handleChange}
          />
            <label>Change</label>
        </div>
        <input type="submit" value="Submit" />
      </form>
    </div>
  );
};

export default MontyHallProblem;
