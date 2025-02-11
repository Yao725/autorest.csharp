import { passOnSuccess, ScenarioMockApi, mockapi } from "@azure-tools/cadl-ranch-api";

export const Scenarios: Record<string, ScenarioMockApi> = {};

const spreadModelRequest = {
    name: "dog",
    age: 3
};

const spreadAliasRequest = {
    name: "dog",
    age: 3
};

const spreadMultiTargetAliasRequest = {
    name: "dog",
    age: 3
};

const spreadAliasWithModelRequest = {
    name: "dog",
    age: 3
};

const spreadAliasWithSpreadAliasRequest = {
    name: "dog",
    age: 3
};

const spreadAliasWithoutOptionalPropRequest = {
    name: "dog",
    items: [1, 2, 3],
};

const spreadAliasWithOptionalPropRequest = {
    name: "dog",
    color: "red",
    age: 3,
    items: [1, 2, 3, 4],
    elements: ["a", "b"]
};

Scenarios.Spread_spreadModel = passOnSuccess(
    mockapi.post("/spreadModel", (req) => {
        req.expect.bodyEquals(spreadModelRequest);
        return {
            status: 204
          };
    }),
);

Scenarios.Spread_spreadAlias = passOnSuccess(
    mockapi.post("/spreadAlias", (req) => {
        req.expect.bodyEquals(spreadAliasRequest);
        return {
            status: 204
          };
    }),
);

Scenarios.Spread_spreadMultiTargetAlias = passOnSuccess(
    mockapi.post("/spreadMultiTargetAlias/1", (req) => {
        req.expect.bodyEquals(spreadMultiTargetAliasRequest);
        req.expect.containsHeader("top", "1");
        return {
            status: 204
          };
    }),
);

Scenarios.Spread_spreadAliasWithModel = passOnSuccess(
    mockapi.post("/spreadAliasWithModel/1", (req) => {
        req.expect.bodyEquals(spreadAliasWithModelRequest);
        req.expect.containsHeader("top", "1");
        return {
            status: 204
          };
    }),
);

Scenarios.Spread_spreadAliasWithSpreadAlias = passOnSuccess(
    mockapi.post("/spreadAliasWithSpreadAlias/1", (req) => {
        req.expect.bodyEquals(spreadAliasWithSpreadAliasRequest);
        req.expect.containsHeader("top", "1");
        return {
            status: 204
          };
    }),
);

Scenarios.Spread_spreadAliasWithoutOptionalProps = passOnSuccess(
    mockapi.post("/spreadAliasWithOptionalProps/1", (req) => {
        req.expect.bodyEquals(spreadAliasWithoutOptionalPropRequest);
        req.expect.containsHeader("top", "1");
        return {
            status: 204
          };
    }),
);

Scenarios.Spread_spreadAliasWithOptionalProps = passOnSuccess(
    mockapi.post("/spreadAliasWithOptionalProps/2", (req) => {
        req.expect.bodyEquals(spreadAliasWithOptionalPropRequest);
        req.expect.containsHeader("top", "1");
        return {
            status: 204
          };
    }),
);
